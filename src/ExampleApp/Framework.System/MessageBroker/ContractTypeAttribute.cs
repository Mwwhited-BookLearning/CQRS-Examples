namespace System.MessageBroker;

[AttributeUsage(AttributeTargets.Class)]
public class ContractTypeAttribute : Attribute
{
    public string? Name { get; set; }
    public string? Owner { get; set; }

    public override object TypeId => this;
}