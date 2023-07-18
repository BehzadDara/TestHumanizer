using System.ComponentModel;

namespace TestHumanizer
{
    public enum MyEnum
    {
        [Description("blue color description")]
        Blue,
        [Description("red color description")]
        Red,
        [Description("green color description")]
        Green,
        [Description("yellow color description")] 
        Yellow
    }
}
