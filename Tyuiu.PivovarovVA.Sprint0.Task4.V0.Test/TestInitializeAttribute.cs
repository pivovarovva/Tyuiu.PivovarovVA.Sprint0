using System.Diagnostics;

namespace Tyuiu.PivovarovVA.Sprint.Task4.V0.Test
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class DataServiceTest
    {
        internal class TestInitializeAttribute : Attribute
        {
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}   

