using System;

namespace Lab1.Extensions
{
	public static class TypeExtensions
	{
		public static string GetModifiersString(this Type type)
		{
			return $"{type.Name} has {type.Attributes.ToString()}";
		}
	}
}