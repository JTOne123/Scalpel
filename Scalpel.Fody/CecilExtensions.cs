using System.Linq;
using Mono.Cecil;

public static class CecilExtensions
{
    public static void RemoveType(this ModuleDefinition module, TypeDefinition type)
    {
        if (type.IsNested)
        {
            var enclosingType = type.DeclaringType;
            enclosingType.NestedTypes.Remove(type);
        }
        else
        {
            module.Types.Remove(type);
        }
    }

    public static bool Implements(this TypeDefinition typeDefinition, string interfaceName)
    {
        return typeDefinition.Interfaces.Any(_ => _.InterfaceType.FullName == interfaceName);
    }
}