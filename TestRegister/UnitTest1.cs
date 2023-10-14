using Microsoft.Win32;
using RegisterLab1;

namespace TestRegister
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1() // כמדטם - םמלונ עוכופמםא ג םמנלאכüםמל גטהו, ךמננוךעםûו ןאנמכט
        {
            var expected = "True";
            var actual = Register.CheckRegister("+7-983-392-1798", "Àא_1234567", "Àא_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test2() // כמדטם - ןמקעא ג םמנלאכüםמל גטהו, ךמננוךעםûו ןאנמכט
        {
            var expected = "True";
            var actual = Register.CheckRegister("fartyshevaeo@mer.ci.nsu.ru", "Àא_1234567", "Àא_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test3() // כמדטם - םאבמנ סטלגמכמג, ךמננוךעםûו ןאנמכט
        {
            var expected = "True";
            var actual = Register.CheckRegister("yeKatOd@_12", "Àא_1234567", "Àא_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test4() // כמדטם - םמלונ עוכופמםא ג םוןנאגטכüםמל פמנלאעו, ךמננוךעםûו ןאנמכט
        {
            var expected = "False";
            var actual = Register.CheckRegister("+79833921798", "Àא_1234567", "Àא_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test5() // כמדטם - םמלונ עוכופמםא, ג ךמעמנמל במכüרו צטפנ, קול המכזםמ בûעü, ךמננוךעםûו ןאנמכט
        {
            var expected = "False";
            var actual = Register.CheckRegister("+789833921798", "Àא_1234567", "Àא_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test6() // כמדטם - םמלונ ןמקעא, ג ךמעמנמי הגא סטלגמכא @, קול המכזםמ בûעü, ךמננוךעםûו ןאנמכט
        {
            var expected = "False";
            var actual = Register.CheckRegister("fartyshevaeo@@mer.ci.nsu.ru", "Àא_1234567", "Àא_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test7() // כמדטם - ןמקעא םוןנאגטכüםמדמ פמנלאעא, קול המכזםמ בûעü, ךמננוךעםûו ןאנמכט
        {
            var expected = "False";
            var actual = Register.CheckRegister("fartyshevaeo@", "Àא_1234567", "Àא_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test8() // כמדטם ךמנמקו קול המכזום בûעü
        {
            var expected = "False";
            var actual = Register.CheckRegister("fart", "Àא_1234567", "Àא_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test9() // לאךסטלאכüםמ הכטםםûי כמדטם
        {
            var expected = "False";
            var actual = Register.CheckRegister("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "Àא_1234567", "Àא_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test10() // כמדטם ס ךטנטככטצוי
        {
            var expected = "False";
            var actual = Register.CheckRegister("כמכמכמרךא", "Àא_1234567", "Àא_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test11() // כמדטם ג ךמננוךעםמל פמנלאעו
        {
            var expected = "True";
            var actual = Register.CheckRegister("yekatya123_", "Àא_1234567", "Àא_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test12() // סמגןאהוםטו ס כמדטםאלט טח סןטסךא
        {
            var expected = "False";
            var actual = Register.CheckRegister("user11", "Àא_1234567", "Àא_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test13() // ןאנמכü ס ךמננוךעםûל פמנלאעמל, ס טסןמכüחמגאםטול ךטנטככטצû, צטפנ ט סןוצסטלגמכמג
        {
            var expected = "True";
            var actual = Register.CheckRegister("yekatod123_", "Àא_1234567@", "Àא_1234567@");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test14() // ןאנמכü ס כאעטםטצוי
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_", "ÀאFF_1234567@", "ÀאFF_1234567@");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test15() // ןאנמכü, ךמעמנûי ךמנמקו 7 סטלגמכמג
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_", "À", "À");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test16() // הכטטטטטטטטטטםםûי ןאנמכü
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_",
            "ייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייי" +
            "ייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייייי", "À");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test17() // ןאנמכü בוח בףךג גונץםודמ נודטסענא
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_", "אאאאאאאאאאאאא1_", "אאאאאאאאאאאאא1_");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test18() // ןאנמכü בוח בףךג םטזםודממ נודטסענא
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_", "ÀÀÀÀÀÀÀÀÀÀÀÀ1_", "ÀÀÀÀÀÀÀÀÀÀÀÀ1_");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test19() // ןאנמכü בוח צטפנ
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_", "Àבמבאאא_", "Àבמבאאא_");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test20() // ןאנמכü בוח סןוצסטלגמכמג
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_", "Àבמבא111", "Àבמבא111");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test21() // ןאנמכü םו סמגןאהא‏ע
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_", "Àבמבא111", "Àבמבא112");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test22() // ןאנמכט םו סמגןאהא‏ע ןמ נודטסענף
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_", "Àבמבא111", "ÀÁמבא111");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }
    }
}