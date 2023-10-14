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
        public void Test1() // ����� - ����� �������� � ���������� ����, ���������� ������
        {
            var expected = "True";
            var actual = Register.CheckRegister("+7-983-392-1798", "��_1234567", "��_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test2() // ����� - ����� � ���������� ����, ���������� ������
        {
            var expected = "True";
            var actual = Register.CheckRegister("fartyshevaeo@mer.ci.nsu.ru", "��_1234567", "��_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test3() // ����� - ����� ��������, ���������� ������
        {
            var expected = "True";
            var actual = Register.CheckRegister("yeKatOd@_12", "��_1234567", "��_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test4() // ����� - ����� �������� � ������������ �������, ���������� ������
        {
            var expected = "False";
            var actual = Register.CheckRegister("+79833921798", "��_1234567", "��_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test5() // ����� - ����� ��������, � ������� ������ ����, ��� ������ ����, ���������� ������
        {
            var expected = "False";
            var actual = Register.CheckRegister("+789833921798", "��_1234567", "��_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test6() // ����� - ����� �����, � ������� ��� ������� @, ��� ������ ����, ���������� ������
        {
            var expected = "False";
            var actual = Register.CheckRegister("fartyshevaeo@@mer.ci.nsu.ru", "��_1234567", "��_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test7() // ����� - ����� ������������� �������, ��� ������ ����, ���������� ������
        {
            var expected = "False";
            var actual = Register.CheckRegister("fartyshevaeo@", "��_1234567", "��_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test8() // ����� ������ ��� ������ ����
        {
            var expected = "False";
            var actual = Register.CheckRegister("fart", "��_1234567", "��_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test9() // ����������� ������� �����
        {
            var expected = "False";
            var actual = Register.CheckRegister("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "��_1234567", "��_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test10() // ����� � ����������
        {
            var expected = "False";
            var actual = Register.CheckRegister("���������", "��_1234567", "��_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test11() // ����� � ���������� �������
        {
            var expected = "True";
            var actual = Register.CheckRegister("yekatya123_", "��_1234567", "��_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test12() // ���������� � �������� �� ������
        {
            var expected = "False";
            var actual = Register.CheckRegister("user11", "��_1234567", "��_1234567");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test13() // ������ � ���������� ��������, � �������������� ���������, ���� � ������������
        {
            var expected = "True";
            var actual = Register.CheckRegister("yekatod123_", "��_1234567@", "��_1234567@");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test14() // ������ � ���������
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_", "��FF_1234567@", "��FF_1234567@");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test15() // ������, ������� ������ 7 ��������
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_", "�", "�");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test16() // ���������������� ������
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_",
            "���������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������" +
            "���������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������", "�");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test17() // ������ ��� ���� �������� ��������
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_", "�������������1_", "�������������1_");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test18() // ������ ��� ���� �������� ��������
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_", "������������1_", "������������1_");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test19() // ������ ��� ����
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_", "�������_", "�������_");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test20() // ������ ��� ������������
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_", "�����111", "�����111");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test21() // ������ �� ���������
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_", "�����111", "�����112");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test22() // ������ �� ��������� �� ��������
        {
            var expected = "False";
            var actual = Register.CheckRegister("yekatod123_", "�����111", "�����111");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }
    }
}