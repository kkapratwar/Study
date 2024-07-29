using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.CSharp
{
    public record RecordExample(int a, int b);

    public record RecordExampleWithParam(int a, int b)
    {
        public int c = a + b;

        public void xyz()
        {
            Console.WriteLine("test");
        }
    };

    public class RecordTests
    {
        public RecordTests()
        {
            var recordExample = new RecordExample(1, 2);
            var recordExmapleWIthParam = new RecordExampleWithParam(1, 2);

            var xx = recordExmapleWIthParam.c;
            recordExmapleWIthParam.xyz();
        }
    }
}
