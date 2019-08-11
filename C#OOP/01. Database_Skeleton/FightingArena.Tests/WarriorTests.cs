using FightingArena;
using NUnit.Framework;
using System;

namespace FightingArena
{
    public class WarriorTests
    {

        private Warrior warrior;

        [SetUp]
        public void Setup()
        {
             
        }

        [Test]
        public void Test_Warrior_Constructor()
        {
            string testName = "Test";
            int testDmg = 10;
            int testHp = 10;
            var currentWarior = new Warrior(testName, testDmg, testHp);

            Assert.AreEqual(testName, currentWarior.Name);
            Assert.AreEqual(testDmg , currentWarior.Damage);
            Assert.AreEqual(testHp, currentWarior.HP);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void Test_WarriorNameProperty_ShoudTrowExceptionIfNullOrEmpty(string name)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, 10, 10));
        }


        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void Test_WarriorDamage_ShoudThrowExceptionIFValuoAreZeroORNegative(int damage)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Pesho", damage, 10));
        }

        
        [Test]
        [TestCase(-1)]
        public void Test_WarriorHP_ShoudThrowExceptionIFValuoAreNegative(int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Pesho", 10, hp));
        }



        
        [Test]
        [TestCase(30)]
        [TestCase(29)]
        public void Test_WarriorAttack_ShoudThrowExceptionIfAtackerHealthIsBelowOrEqual30(int hp)
        {
           var  warriorThatAttack = new Warrior("pesho", 10, hp);
            var warriorTahanBeenAttacked = new Warrior("Gosho", 10, 100);

            Assert.Throws<InvalidOperationException>(() => warriorThatAttack.Attack(warriorTahanBeenAttacked));
        }


        [Test]
        [TestCase(30)]
        [TestCase(29)]
        public void Test_WarriorAttack_ShoudThrowExceptionIfAttackerTryToAttackWarriorWithHPBelowOrEqual30(int hp)
        {
            var warriorThatAttack = new Warrior("pesho", 10, 100);
            var warriorTahanBeenAttacked = new Warrior("Gosho", 10, hp);

            Assert.Throws<InvalidOperationException>(() => warriorThatAttack.Attack(warriorTahanBeenAttacked));
        }

       
        [Test]
        public void Test_WarriorAttack_ShoudThrowExceptionIfAttackerTryToAttackWarriorWithDamageMoreThatHisHealth()
        {
            var warriorThatAttack = new Warrior("pesho", 10, 31);
            var warriorTahanBeenAttacked = new Warrior("Gosho", 100, 50);

            Assert.Throws<InvalidOperationException>(() => warriorThatAttack.Attack(warriorTahanBeenAttacked));
        }

        [Test]
        public void Test_WarriorAttack_ShoudReduceAttackerHelathEqualAttackedWarriorDamage()
        {
            var attackerHp = 50;
            var attackedDamage = 30;
            var result = Math.Abs(attackerHp - attackedDamage);
            var warriorThatAttack = new Warrior("pesho", 10, attackerHp);
            var warriorTahanBeenAttacked = new Warrior("Gosho", attackedDamage, 50);
            warriorThatAttack.Attack(warriorTahanBeenAttacked);
            Assert.AreEqual(result, warriorThatAttack.HP);
        }

        [Test]
        public void Test_WarriorAttack_AttackedWarriorHpShoudSetToZeroIfAttackerDmgIsMoreThanHisHp()
        {
            var attackerDamage = 50;
            var attackedHp = 31;
            
            var warriorThatAttack = new Warrior("pesho", attackerDamage, 100);
            var warriorTahanBeenAttacked = new Warrior("Gosho", 10, attackedHp);
            warriorThatAttack.Attack(warriorTahanBeenAttacked);
            Assert.AreEqual(0, warriorTahanBeenAttacked.HP);
        }

        [Test]
        public void Test_WarriorAttack_AttackedWarriorHpShoudReduceAfterAttack()
        {
            var attackerDamage = 30;
            var attackedHp = 31;
            var result = Math.Abs(attackerDamage - attackedHp);
            var warriorThatAttack = new Warrior("pesho", attackerDamage, 100);
            var warriorTahanBeenAttacked = new Warrior("Gosho", 10, attackedHp);
            warriorThatAttack.Attack(warriorTahanBeenAttacked);
            Assert.AreEqual(result, warriorTahanBeenAttacked.HP);
        }

    }
}