using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Texac
{
    public class SortableBindingList<T> : BindingList<T> where T : class
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection = ListSortDirection.Ascending;
        private PropertyDescriptor _sortProperty;

        private List<T> _originalList;
        private Predicate<T> _filterPredicate;
        private bool _isFiltered;

        /// <summary>
        /// Initializes a new instance of the <see cref="SortableBindingList{T}"/> class.
        /// </summary>
        public SortableBindingList()
        {
            _originalList = new List<T>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortableBindingList{T}"/> class.
        /// </summary>
        /// <param name="list">An <see cref="T:System.Collections.Generic.IList`1" /> of items to be contained in the <see cref="T:System.ComponentModel.BindingList`1" />.</param>
        public SortableBindingList(IList<T> list) : base(list)
        {
            _originalList = new List<T>(list);
        }

        #region Sorting Methods (Previous Implementation)
        // ... (Keep the previous sorting methods unchanged)
        protected override bool SupportsSortingCore => true;
        protected override bool IsSortedCore => _isSorted;
        protected override ListSortDirection SortDirectionCore => _sortDirection;
        protected override PropertyDescriptor SortPropertyCore => _sortProperty;

        protected override void RemoveSortCore()
        {
            _sortDirection = ListSortDirection.Ascending;
            _sortProperty = null;
            _isSorted = false;
        }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            _sortProperty = prop;
            _sortDirection = direction;

            List<T> list = Items as List<T>;
            if (list == null) return;

            list.Sort(Compare);

            _isSorted = true;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        private int Compare(T lhs, T rhs)
        {
            var result = OnComparison(lhs, rhs);
            if (_sortDirection == ListSortDirection.Descending)
                result = -result;
            return result;
        }

        private int OnComparison(T lhs, T rhs)
        {
            object lhsValue = lhs == null ? null : _sortProperty.GetValue(lhs);
            object rhsValue = rhs == null ? null : _sortProperty.GetValue(rhs);
            if (lhsValue == null)
            {
                return (rhsValue == null) ? 0 : -1;
            }
            if (rhsValue == null)
            {
                return 1;
            }
            if (lhsValue is IComparable)
            {
                return ((IComparable)lhsValue).CompareTo(rhsValue);
            }
            if (lhsValue.Equals(rhsValue))
            {
                return 0;
            }
            return lhsValue.ToString().CompareTo(rhsValue.ToString());
        }
        #endregion

        #region Filtering Methods
        /// <summary>
        /// Применяет фильтр к списку на основе переданного предиката
        /// </summary>
        /// <param name="filterPredicate">Предикат для фильтрации элементов</param>
        public void ApplyFilter(Predicate<T> filterPredicate)
        {
            // Если это первая фильтрация, сохраняем оригинальный список
            if (!_isFiltered)
            {
                _originalList = new List<T>(this);
            }

            _filterPredicate = filterPredicate;
            _isFiltered = true;

            // Очищаем текущий список
            ClearItems();

            // Добавляем только элементы, прошедшие фильтр
            foreach (var item in _originalList)
            {
                if (filterPredicate(item))
                {
                    Add(item);
                }
            }

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        /// <summary>
        /// Удаляет текущий фильтр и восстанавливает исходный список
        /// </summary>
        public void RemoveFilter()
        {
            if (!_isFiltered) return;

            // Очищаем текущий список
            ClearItems();

            // Восстанавливаем оригинальный список
            foreach (var item in _originalList)
            {
                Add(item);
            }

            _filterPredicate = null;
            _isFiltered = false;

            if(_isSorted)
            {
                ApplySortCore(_sortProperty, _sortDirection);
            }

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        /// <summary>
        /// Проверяет, применен ли в данный момент фильтр
        /// </summary>
        public bool IsFiltered => _isFiltered;
        #endregion
    }
}
