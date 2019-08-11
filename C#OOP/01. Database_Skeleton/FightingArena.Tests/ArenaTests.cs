using FightingArena;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FightingArena
{
    public class ArenaTests
    {

        
        private Arena arena;

        [SetUp]
        public void Setup()
        {
            var firstWarrior = new Warrior("Pesho", 50, 50);
            var secondWarrior = new Warrior("Gosho", 51, 51);
            arena = new Arena();
            arena.Enroll(firstWarrior);
            arena.Enroll(secondWarrior);




        }

        [Test]
        public void Test_Arena_Constructor()
        {
            var arena = new Arena();
            Assert.IsNotNull(arena);
        }


        [Test]
        public void Test_ArenaCount()
        {
            var result = 2;
            Assert.AreEqual(result, arena.Count);
        }


        [Test]
        public void Test_ArenaEnroll_ShoudThrowExceptionIfWarriorNameExist()
        {
            var warrior = new Warrior("Pesho", 50, 50);

            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));

        }
        [Test]
        public void Test_ArenaEnroll_ShoudAddCorrectly()
        {
            var warrior = new Warrior("Rado", 50, 50);
            var expectedCount = 3;
            arena.Enroll(warrior);
            Assert.AreEqual(expectedCount, arena.Count);

        }
        [Test]
        public void Test_ArenaFight_ShoudThrowExeptionIFAttackerNameDoesntExist()
        {
            string nameThatDoesntExist = "Stavri";
            Assert.Throws<InvalidOperationException>(() => arena.Fight(nameThatDoesntExist, "Pesho"));
        }

        [Test]
        public void Test_ArenaFight_ShoudThrowExeptionIFDeffenderNameDoesntExist()
        {
            string nameThatDoesntExist = "Stavri";
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Pesho", nameThatDoesntExist));
        }


        [Test]
        public void Test_ArenaFight_ShoudWorkCorrectly()
        {
            var warrior1 = new Warrior("Batman", 5, 100);
            var warrior2 = new Warrior("Zoro", 10, 50);

            this.arena.Enroll(warrior1);
            this.arena.Enroll(warrior2);

            this.arena.Fight("Batman", "Zoro");

            Assert.AreEqual(90, warrior1.HP);
            Assert.AreEqual(45, warrior2.HP);
        }
    }
}
