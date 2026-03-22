using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace QuickBooksHandler.My;

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[DebuggerNonUserCode]
internal sealed class InternalXmlHelper
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	private sealed class RemoveNamespaceAttributesClosure
	{
		private readonly string[] m_inScopePrefixes;

		private readonly XNamespace[] m_inScopeNs;

		private readonly List<XAttribute> m_attributes;

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal RemoveNamespaceAttributesClosure(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes)
		{
			m_inScopePrefixes = inScopePrefixes;
			m_inScopeNs = inScopeNs;
			m_attributes = attributes;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal XElement ProcessXElement(XElement elem)
		{
			return RemoveNamespaceAttributes(m_inScopePrefixes, m_inScopeNs, m_attributes, elem);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal object ProcessObject(object obj)
		{
			if (obj is XElement elem)
			{
				return RemoveNamespaceAttributes(m_inScopePrefixes, m_inScopeNs, m_attributes, elem);
			}
			return obj;
		}
	}

	public static string GetValue(IEnumerable<XElement> source)
	{
		using (IEnumerator<XElement> enumerator = source.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				XElement item = enumerator.Current;
				return item.Value;
			}
		}
		return null;
	}

	public static void SetValue(IEnumerable<XElement> source, string value)
	{
		using IEnumerator<XElement> enumerator = source.GetEnumerator();
		if (enumerator.MoveNext())
		{
			XElement item = enumerator.Current;
			item.Value = value;
		}
	}

	public static string GetAttributeValue(IEnumerable<XElement> source, XName name)
	{
		using (IEnumerator<XElement> enumerator = source.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				XElement item = enumerator.Current;
				return (string)item.Attribute(name);
			}
		}
		return null;
	}

	public static void SetAttributeValue(IEnumerable<XElement> source, XName name, string value)
	{
		using IEnumerator<XElement> enumerator = source.GetEnumerator();
		if (enumerator.MoveNext())
		{
			XElement item = enumerator.Current;
			item.SetAttributeValue(name, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	private InternalXmlHelper()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XAttribute CreateAttribute(XName name, object value)
	{
		if (value == null)
		{
			return null;
		}
		return new XAttribute(name, RuntimeHelpers.GetObjectValue(value));
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XAttribute CreateNamespaceAttribute(XName name, XNamespace ns)
	{
		XAttribute a = new XAttribute(name, ns.NamespaceName);
		a.AddAnnotation(ns);
		return a;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static object RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, object obj)
	{
		if (obj != null)
		{
			if (obj is XElement elem)
			{
				return InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, elem);
			}
			if (obj is IEnumerable elems)
			{
				return InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, elems);
			}
		}
		return obj;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IEnumerable RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, IEnumerable obj)
	{
		if (obj != null)
		{
			if (obj is IEnumerable<XElement> elems)
			{
				return elems.Select(new RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessXElement);
			}
			return obj.Cast<object>().Select(new RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessObject);
		}
		return obj;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XElement RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, XElement e)
	{
		checked
		{
			if (e != null)
			{
				XAttribute a = e.FirstAttribute;
				while (a != null)
				{
					XAttribute nextA = a.NextAttribute;
					if (a.IsNamespaceDeclaration)
					{
						XNamespace ns = a.Annotation<XNamespace>();
						string prefix = a.Name.LocalName;
						if ((object)ns != null)
						{
							if ((inScopePrefixes != null && inScopeNs != null) ? true : false)
							{
								int lastIndex = inScopePrefixes.Length - 1;
								int num = lastIndex;
								int i = 0;
								while (true)
								{
									int num2 = i;
									int num3 = num;
									if (num2 > num3)
									{
										break;
									}
									string currentInScopePrefix = inScopePrefixes[i];
									XNamespace currentInScopeNs = inScopeNs[i];
									if (prefix.Equals(currentInScopePrefix))
									{
										if (ns == currentInScopeNs)
										{
											a.Remove();
										}
										a = null;
										break;
									}
									i++;
								}
							}
							if (a != null)
							{
								if (attributes != null)
								{
									int lastIndex2 = attributes.Count - 1;
									int num4 = lastIndex2;
									int i2 = 0;
									while (true)
									{
										int num5 = i2;
										int num3 = num4;
										if (num5 > num3)
										{
											break;
										}
										XAttribute currentA = attributes[i2];
										string currentInScopePrefix2 = currentA.Name.LocalName;
										XNamespace currentInScopeNs2 = currentA.Annotation<XNamespace>();
										if ((object)currentInScopeNs2 != null && prefix.Equals(currentInScopePrefix2))
										{
											if (ns == currentInScopeNs2)
											{
												a.Remove();
											}
											a = null;
											break;
										}
										i2++;
									}
								}
								if (a != null)
								{
									a.Remove();
									attributes.Add(a);
								}
							}
						}
					}
					a = nextA;
				}
			}
			return e;
		}
	}
}
