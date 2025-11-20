# Refactored Code

```csharp
public class Employee // changed class name
{
    // Converted field names to properties in PascalCase
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public void CalculateAnnualSalary() // used descriptive name for method in PascalCase
    {
        // used descriptive names for local variables in camelCase
        double bonusSalary = Salary * 0.1;
        double totalSalary = Salary + bonusSalary;
    }
}
```

---

# Comparison Document

| Original Name | Refactored Name         | Reason/Explanation                                      |
|---------------|------------------------|---------------------------------------------------------|
| `emp`         | `Employee`             | Class names use PascalCase and should be descriptive.   |
| `n`           | `Name`                 | Property names use PascalCase and should be meaningful. |
| `a`           | `Age`                  | Property names use PascalCase and should be meaningful. |
| `s`           | `Salary`               | Property names use PascalCase and should be meaningful. |
| `calc()`      | `CalculateAnnualSalary()` | Method names use PascalCase and should be descriptive.  |
| `x`           | `bonusSalary`          | Local variable names use camelCase and should be descriptive. |
| `y`           | `totalSalary`          | Local variable names use camelCase and should be descriptive. |


