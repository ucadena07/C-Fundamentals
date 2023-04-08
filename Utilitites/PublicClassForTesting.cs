namespace Utilitites;

public class PublicClassForTesting
{
    public int PublicProp { get; set; }
    internal int InternalProp { get; set; }
    protected int ProtectedProp { get; set; }
    protected internal int ProtectedInternalProp { get; set; }
    private protected int PrivateProtectedProperty { get; set; }    

    public void PublicMethod()
    {
        Console.WriteLine("I am a public method in another project");
        PrivateMethod();

        FileClass fi = new FileClass();
    }

    void PrivateMethod()
    {
        Console.WriteLine("I am a private method in another project");
    }



}
file class FileClass
{

}