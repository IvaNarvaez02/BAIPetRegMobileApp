using System.Text.RegularExpressions;

namespace AlphaValidationBehavior;

public class AlphabeticValidationBehavior : Behavior<Entry>
{
    protected override void OnAttachedTo(Entry bindable)
    {
        bindable.TextChanged += OnEntryTextChanged;
        base.OnAttachedTo(bindable);
    }

    protected override void OnDetachingFrom(Entry bindable)
    {
        bindable.TextChanged -= OnEntryTextChanged;
        base.OnDetachingFrom(bindable);
    }

    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        if (!IsValid(e.NewTextValue))
        {
            ((Entry)sender).Text = e.OldTextValue;
        }
    }

    bool IsValid(string str)
    {
        // Return false if the input is null or empty
        if (string.IsNullOrEmpty(str))
        {
            return false;
        }

        return Regex.IsMatch(str, "^[a-zA-Z]*$");
    }
}