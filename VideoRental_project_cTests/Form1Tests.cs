using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRental_project_c;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental_project_c.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            opertionLogic opertion = new opertionLogic();
            if (opertion.InsClient("ok", "6564456", "NZ")){

                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
            
        }

        [TestMethod()]
        public void Form2Test()
        {
            opertionLogic opertion = new opertionLogic();
            if (opertion.UpdtClient(1,"Grry", "6564456", "NZ"))
            {

                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

        }


    }
}