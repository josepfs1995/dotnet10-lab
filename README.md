# C# 14

## 🔧 Fields

La palabra clave **Fields** te permite usar el campo interno de una propiedad automática dentro de get o set, sin declararlo manualmente. Ayuda a agregar lógica de validación de forma simple

```csharp
public class FieldKeyword
{
   public int Stock { get; set => field = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Stock must be greater than 0"); }
}
```

## ❕ Nameof

Nameof soporta tipo genericos sin enlazar:

```csharp
var name = nameof(List<>);
```