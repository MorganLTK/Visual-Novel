using Yarn.Unity;

[System.CodeDom.Compiler.GeneratedCode("YarnSpinner", "3.2.4.0")]
public partial class YarnVariables : Yarn.Unity.InMemoryVariableStorage, Yarn.Unity.IGeneratedVariableStorage {
    // Accessor for String $target
    public string Target {
        get => this.GetValueOrDefault<string>("$target");
        set => this.SetValue<string>("$target", value);
    }

    // Accessor for Number $likeness
    public float Likeness {
        get => this.GetValueOrDefault<float>("$likeness");
        set => this.SetValue<float>("$likeness", value);
    }

}
