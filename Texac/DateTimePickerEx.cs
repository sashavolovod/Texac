using System;
using System.Windows.Forms;

public class  DateTimePickerEx : System.Windows.Forms.DateTimePicker
{
    private DateTimePickerFormat originalFormat = DateTimePickerFormat.Short;
    private string originalCustomFormat;
    private bool isNull;

    public new DateTime Value
    {
        get
        {
            return isNull ? DateTime.MinValue : base.Value;
        }
        set
        {
            // incoming value is set to min date
            if (value == DateTime.MinValue)
            {
                // if set to min and not previously null, preserve original formatting
                if (!isNull)
                {
                    originalFormat = this.Format;
                    originalCustomFormat = this.CustomFormat;
                    isNull = true;
                }

                this.Format = DateTimePickerFormat.Custom;
                this.CustomFormat = " ";
            }
            else // incoming value is real date
            {
                // if set to real date and previously null, restore original formatting
                if (isNull)
                {
                    this.Format = originalFormat;
                    this.CustomFormat = originalCustomFormat;
                    isNull = false;
                }

                base.Value = value;
            }
        }
        }

    protected override void OnCloseUp(EventArgs eventargs)
    {
        // on keyboard close, restore format
        if (Control.MouseButtons == MouseButtons.None)
        {
            if (isNull)
            {
                this.Format = originalFormat;
                this.CustomFormat = originalCustomFormat;
                isNull = false;
            }
        }
        base.OnCloseUp(eventargs);
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e);

        // on delete key press, set to min value (null)
        if (e.KeyCode == Keys.Delete)
        {
            this.Value = DateTime.MinValue;
        }
    }
}