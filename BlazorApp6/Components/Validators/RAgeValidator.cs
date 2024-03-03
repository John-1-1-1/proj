using System.ComponentModel.DataAnnotations;

namespace BlazorApp6.Components.Validators;

public class RAgeValidator() : RangeAttribute(typeof(DateOnly),
    DateTime.Now.AddYears(-90).ToShortDateString(),
    DateTime.Now.ToShortDateString());
