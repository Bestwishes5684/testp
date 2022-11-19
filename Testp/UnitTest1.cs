using FluentAssertions;
using Library;


namespace Testp
{
    public class UnitTest1
    {

        public void AddButton()
        {
            ipdz SCL = new();
            var result = SCL.Get();
            Student test1 = new()
            {
                FullName = "Рома",
                Datarod = DateTime.Now.ToString("d"),
                Gender = Gender.Male.ToString("d"),
                FormOB = FormOB.fulltime.ToString("d"),
                inf = 100,
                Math = 100,
                Russ = 100,
                total = 300
            };
            SCL.Add(test1);
            test1.FullName.Should().Be("Рома");
            Assert.Equal(test1, result[0]);
        }

        [Fact]
        public void ChangeButton()
        {
            ipdz SCL = new();
            var result = SCL.Get();
            Student test2 = new()
            {
                FullName = "Гена",
                Datarod = DateTime.Now.ToString("d"),
                Gender = Gender.Male.ToString("d"),
                FormOB = FormOB.fulltime.ToString("d"),
                inf = 50,
                Math = 10,
                Russ = 50,
                total = 110
            };
            test2.total.Should().Be(test2.inf + test2.Russ + test2.Math);
            test2.FullName.Should().Be("Гена");
            test2.Russ.Should().Be(50);
            

        }
        [Fact]
        public void DeleteButton()
        {
            ipdz SCL = new();
            var result = SCL.Get();
            Student test4 = new()
            {
                FullName = "Никита",
                Datarod = DateTime.Now.ToString("d"),
                Gender = Gender.Male.ToString("d"),
                FormOB = FormOB.fulltime.ToString("d"),
                inf = 10,
                Math = 50,
                Russ = 50,
                total = 110
            };
            test4.FullName.Should().Be("Никита");
            test4.total.Should().Be(test4.inf + test4.Russ + test4.Math);
            test4.inf.Should().Be(10);
            SCL.Add(test4);
            SCL.Remove(test4);
            Assert.Empty(result);
        }


    }
}
