using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Game
{
    static class MessageHelper
    {
        static public string getString(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        static public int getInt(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            return Convert.ToInt32(MessageHelper.getString(message));
        }

        static public double getDouble(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            return Convert.ToDouble(MessageHelper.getString(message));
        }

        static public bool getBool(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            return Convert.ToBoolean(MessageHelper.getString(message));
        }
        static public void showText(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(text);

            Console.WriteLine();
        }
    }
    interface IUseSkill
    {
        UseSkillResultData UseSkill(Player player);
        string getName();
    }

    enum SkillType
    {
        BattleSkill = 1,
        RescueSkill,
        OtherSkill
    }

    class UseSkillResultData
    {
        private bool isSuccses = false;
        private int value = 0;
        private string message = "";
        private SkillType skilltype;

        public UseSkillResultData(bool isSuccses, int value, string message, SkillType skilltype)
        {
            this.isSuccses = isSuccses;
            this.value = value;
            this.message = message;
            this.skilltype = skilltype;
        }

        public bool IsSuccses() => isSuccses;
        public int getValue() => value;
        public string getMessage() => message;
        public SkillType GetSkillType() => skilltype;
    }

    abstract class Skill : NameTrait
    {
        protected int epCost = 0;
        public Skill(string name, int cost)
        {
            this.name = name;
            this.epCost = cost;
        }

        protected bool checkSkill(Player player)
        {
            return player.decreaseEp(this.epCost);
        }

        protected int getEpCost() => epCost;
    }

    class Strike : Skill, IUseSkill
    {
        public Strike() : base("Удар", 5)
        {

        }

        public UseSkillResultData UseSkill(Player player)
        {
            int damage = 0;
            bool isSuccses = checkSkill(player);


            if (isSuccses)
            {
                damage = player.CalculateDamage();
            }

            return new UseSkillResultData(isSuccses, damage, "", SkillType.BattleSkill);
        }
    }

    class MightyStrike : Skill, IUseSkill
    {
        public MightyStrike() : base("Сильний Удар", 20)
        {

        }

        public UseSkillResultData UseSkill(Player player)
        {
            int damage = 0;
            bool isSuccses = checkSkill(player);

            if (isSuccses)
            {
                damage = player.CalculateDamage() * 2;
            }

            return new UseSkillResultData(isSuccses, damage, "", SkillType.BattleSkill);
        }
    }

    class Regenration : Skill, IUseSkill
    {
        public Regenration() : base("Регенерація", 60)
        {

        }

        public UseSkillResultData UseSkill(Player player)
        {
            bool isSuccses = checkSkill(player);

            if (isSuccses)
            {
                player.rescueHp(player.getLevel() * 100);
            }

            return new UseSkillResultData(isSuccses, 0, "", SkillType.RescueSkill);
        }
    }

    class Rest : Skill, IUseSkill
    {
        public Rest() : base("Відпочинок", 0)
        {

        }

        public UseSkillResultData UseSkill(Player player)
        {
            player.increaseEp(30);

            return new UseSkillResultData(true, 0, "", SkillType.OtherSkill);
        }
    }
    class Iaido : Skill, IUseSkill
    {
        public Iaido() : base("Iaido", 5)
        {

        }

        public UseSkillResultData UseSkill(Player player)
        {
            int damage = 0;
            bool isSuccses = checkSkill(player);

            if (isSuccses)
            {
                damage = player.CalculateDamage() + 50;
            }

            return new UseSkillResultData(isSuccses, damage, "", SkillType.BattleSkill);
        }
    }
    class Explosion : Skill, IUseSkill
    {
        public Explosion() : base("Explosion", 100)
        {

        }

        public UseSkillResultData UseSkill(Player player)
        {
            int damage = 0;
            bool isSuccses = checkSkill(player);

            if (isSuccses)
            {
                damage = player.CalculateDamage() * 7;
            }

            return new UseSkillResultData(isSuccses, damage, "", SkillType.BattleSkill);
        }
    }
    class DoubleWeapon : Skill, IUseSkill
    {
        public DoubleWeapon() : base("DoubleWeapon", 100)
        {

        }

        public UseSkillResultData UseSkill(Player player)
        {
            int damage = 0;
            bool isSuccses = checkSkill(player);

            if (isSuccses)
            {
                damage = player.getWeapon().getharm() * 2;
            }

            return new UseSkillResultData(isSuccses, damage, "", SkillType.BattleSkill);
        }
    }

    public class Armor : NameTrait
    {
        string armorName = "";
        int protection { get; set; }
        int price { get; set; }
        public Armor(int protection, string armorName)
        {
            this.protection = protection;
            this.armorName = armorName;
        }
        public void setprotection(int protection)
        {
            this.protection = protection;
        }

        public int getprotection()
        {
            return this.protection;
        }
    }
    public class Weapon : NameTrait
    {
        public string weaponName = "";
        public int harm { get; set; }
        int price { get; set; }
        public Weapon(int harm, string weaponName)
        {
            this.harm = harm;
            this.weaponName = weaponName;
        }
        public void setharm(int harm)
        {
            this.harm = harm;
        }

        public int getharm()
        {
            return this.harm;
        }
    }

    class Person : NameTrait
    {
        static private int autoInc = 1;
        protected int id;

        private void generateId()
        {
            this.id = autoInc++;
        }

        protected int level = 0;
        protected int hp = 0;
        protected int ep = 0;
        protected int hpMax = 0;
        public int energy = 500;
        public int enMax = 500;
        public int getEp() => this.ep;
        public void increaseEp(int ep)
        {
            if (this.energy + ep > this.enMax)
            {
                this.energy = this.enMax;
            }
            else
            {
                this.energy += ep;
            }
        }

        public bool decreaseEp(int ep)
        {
            if (this.energy - ep >= 0)
            {
                this.energy -= ep;
                return true;
            }

            return false;
        }



        public int getHp()
        {
            return hp;
        }
        public int getHpMax()
        {
            return hpMax;
        }

        public int getLevel()
        {
            return level;
        }

        public int damageHp(int damage)
        {
            if (hp - damage < 0)
                hp = 0;
            else
                hp -= damage;

            return hp;
        }

        public int rescueHp(int value)
        {
            if (hp + value > hpMax)
                hp = hpMax;
            else
                hp += value;

            return hp;
        }


        protected void showHealthBar()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-= ========== =-");
            Console.WriteLine($"-= {this.name} lvl.{this.level} =-");
            Console.WriteLine("-= ========== =-");
            Console.Write("-=[");

            int count = 0;

            if (hp != 0)
                count = hp / (hpMax / 10);

            if (hp > 0 && count == 0)
                count = 1;

            if (count <= 3)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (count > 3 && count <= 6)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else
                Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 1; i <= 10; i++)
            {
                if (i <= count)
                    Console.Write("#");
                else
                    Console.Write(" ");
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("]=-\n");

            Console.WriteLine($"-= [{this.hp}/{this.hpMax}] =-");
            Console.Write("-=[");

            int count1 = 0;

            if (ep != 0)
                count1 = ep / (enMax / 10);

            if (ep > 0 && count1 == 0)
                count1 = 1;

            if (count1 <= 3)
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            else if (count1 > 3 && count1 <= 6)
                Console.ForegroundColor = ConsoleColor.Blue;
            else
                Console.ForegroundColor = ConsoleColor.Cyan;

            for (int i = 1; i <= 10; i++)
            {
                if (i <= count1)
                    Console.Write("#");
                else
                    Console.Write(" ");
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("]=-\n");

            Console.WriteLine($"-= [{this.ep}/{this.enMax}] =-");
            Console.WriteLine("-= ========== =-");

            Console.ResetColor();
        }

        public string name { get; set; }

        public Person(string name, int level)
        {
            generateId();
            this.name = name;
            this.level = level;
        }
        public void showInfo()
        {
            this.showHealthBar();
        }
    }
    public class NameTrait
    {
        protected string name;

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }
    }
    abstract class Player : Person
    {
        protected int str = 0;
        protected int dex = 0;
        protected int end = 0;
        protected int exp = 0;
        protected int attack = 0;
        protected int protection = 0;
        protected Random random = null;
        protected List<IUseSkill> skills = null;

        Weapon weapon = null;
        Armor armor = null;
        public int GetEn()
        {
            return energy;
        }
        public void changeEn(int value)
        {
            if (value + energy > this.enMax)
            {
                energy = this.enMax;
            }
            else if (value + energy < 0)
            {
                energy = 0;
            }
            else
            {
                energy = value + energy;
            }
        }

        public int GetenMax()
        {
            return enMax;
        }

        public void setWeapon(Weapon weapon) => this.weapon = weapon;
        public Weapon getWeapon() => this.weapon;

        public void setArmor(Armor armor) => this.armor = armor;
        public Armor getArmor() => this.armor;

        public int Damage()
        {
            if (this.weapon == null)
                this.attack = this.str;
            else
                this.attack = this.weapon.getharm() + this.str * 5;

            return this.attack;
        }

        public int Defense()
        {
            if (this.armor == null)
                this.protection = this.end;
            else
                this.protection = this.armor.getprotection() + this.end;

            return protection;
        }

        public int CalculateDamage()
        {
            attack = this.Damage();

            if (dex > 10 && this.random.Next(1, 101) <= dex)
            {
                Console.WriteLine("Critical hit!");
                attack *= 2;
            }

            return attack;
        }

        protected void setBaseHp()
        {
            this.hp = this.hpMax = 50 * this.end;
        }
        public Player(Random random, string name) : base(name, 1)
        {
            this.random = random;
            this.skills = new List<IUseSkill>();
            

        }

        public bool addedSkill(IUseSkill skill)
        {
            foreach (var tmpSkill in this.skills)
            {
                if (tmpSkill.GetType().Name == skill.GetType().Name)
                {
                    throw new Exception("Дублікат вміння!");
                }
            }

            this.skills.Add(skill);
            return true;
        }
        public IUseSkill getSkill(int index)
        {
            return this.skills[index];
        }

        public void showSkills()
        {
            for (int i = 0; i < this.skills.Count; i++)
            {
                Console.WriteLine(i + 1 + " - " + this.skills[i].getName());
            }
        }

        public UseSkillResultData useSkill(int index)
        {

            if (index < 0 || index >= this.skills.Count)
                throw new Exception("Такого індекса не існує!");


            UseSkillResultData data = this.skills[index].UseSkill(this);

            if (!data.IsSuccses())
                Console.WriteLine("Немає енергії!");

            return data;
        }

        public void addExp(int exp) => this.exp += exp;
    }

    class Barbarian : Player
    {
        public Barbarian(Random random, string name) : base(random, name)
        {
            this.str = 30;
            this.dex = 15;
            this.end = 15;
            this.setWeapon(new Weapon(4, "Axe"));

            setBaseHp();
        }
    }
    class Tank : Player
    {
        public Tank(Random random, string name) : base(random, name)
        {
            this.str = 15;
            this.dex = 15;
            this.end = 30;
            this.setWeapon(new Weapon(3, "Sword"));

            setBaseHp();
        }
    }
    class Robber : Player
    {
        public Robber(Random random, string name) : base(random, name)
        {
            this.str = 15;
            this.dex = 30;
            this.end = 15;
            this.setWeapon(new Weapon(5, "Dagger"));

            setBaseHp();
        }
    }

    class Monster : Person
    {
        public int damage { get; set; }
        public int armor { get; set; }
        public int experienceReward { get; set; }
        public int remuneration { get; set; }
        public Monster(string name, int level) : base(name, level)
        {
            this.hp = this.hpMax = level * 500;
            this.energy = level * 100;
            this.damage = level * 50;
            this.armor = level * 10;
            this.experienceReward = level * 100;
            this.remuneration = level * 5;
        }
        public int getExpReward() => this.experienceReward;

        public int getDamage() { return damage; }

        public int getArmor() { return armor; }


    }
    enum PlayerType
    {
        Barbarian = 1,
        Tank,
        Robber
    }
    class Engine
    {

        Random random = null;
        string[] names = { "Zombie", "Canopee", "Vino", "Lavalee", "Sakura", "Spike", "Tanos", "Krab", "Gloomen", "Nimph" };
        string[] armorNames = { "leather armor", "mail armor", "iron armor", "diamond armor", "netherite armor" };
        string[] weaponNames = { "katana", "rapier", "shotgun", "flamethrower", "rifle", "rocket launcher", "sword" };
        public Engine(Random rand)
        {
            this.random = rand;
        }
        protected void showOnePanchInfo(string name, int damage)
        {
            Console.WriteLine($" -= {name} наніс удар, кількість очків шкоди {damage} =- ");
        }
        static public int prepareStrike(int damage, int defence)
        {
            damage = damage - defence;

            if (damage < 0)
                return 1;

            return damage;
        }


        public void battle(Player player)
        {
            Monster monster = this.generateMonster(player.getLevel());
            while (player.getHp() > 0 && monster.getHp() > 0)
            {
                Console.Clear();
                player.showInfo();
                monster.showInfo();

                Console.WriteLine("Виберіть дію: ");
                player.showSkills();
                int choice = Convert.ToInt32(Console.ReadLine());
                UseSkillResultData data = player.useSkill(choice);

                int damage;
                if (data.GetSkillType() == SkillType.BattleSkill)
                {
                    damage = prepareStrike(data.getValue(), monster.getArmor());
                    monster.damageHp(damage);
                    showOnePanchInfo(player.getName(), damage);
                }

                damage = prepareStrike(monster.getDamage(), player.Defense());
                player.damageHp(damage);
                showOnePanchInfo(monster.getName(), damage);

                Console.ReadLine();
            }

            if (player.getHp() > 0)
            {
                Console.WriteLine($"Ви перемогли {monster.getName()} i отримали {monster.getExpReward()} очків досвіду!");

                player.addExp(monster.getExpReward());
            }
            else
            {
                Console.WriteLine("YOU DIED");
            }
        }


        public Monster generateMonster(int level)
        {
            if (level == 1)
                level += this.random.Next(0, 2);
            else
                level += this.random.Next(-1, 2);

            return new Monster(names[random.Next(0, names.Length)], level);
        }

        public Player createPlayer(string name, PlayerType playerType)
        {
            Player player = null;

            if (playerType == PlayerType.Barbarian)
            {

                player = new Barbarian(this.random, name);
                player.addedSkill(new DoubleWeapon());
            }
            else if (playerType == PlayerType.Tank)
            {
                player = new Tank(this.random, name);
                player.addedSkill(new Explosion());
            }
            else if (playerType == PlayerType.Robber)
            {
                player = new Robber(this.random, name);
                player.addedSkill(new Iaido());
            }

            player.addedSkill(new Strike());
            player.addedSkill(new MightyStrike());
            player.addedSkill(new Regenration());
            player.addedSkill(new Rest());

            return player;
        }
        public Armor createArmor(int protection = 0, string armorName = "")
        {
            if (protection == 0)
            {
                protection = random.Next(3, 20);
            }

            if (armorName.Length == 0)
            {
                armorName = armorNames[random.Next(0, armorNames.Length)];
            }

            return new Armor(protection, armorName);
        }
        public Weapon createWeapon(int harm, string weaponName)
        {
            weaponName = weaponNames[random.Next(0, weaponNames.Length)];
            harm = random.Next(3, 20);
            return new Weapon(harm, weaponName);
        }
    }
    class Events
    {
        public void randomEvent(Random random, int ranEv, int characteristics, Player player)
        {
            characteristics = random.Next(1, 3);
            ranEv = random.Next(1, 3);
            if (ranEv == 1)
            {
                if (characteristics == 1)
                {
                    if (player.GetEn() != player.GetenMax())
                    {
                        player.energy += 10;
                    }
                }
                else
                {
                    player.energy -= 10;
                }
            }
            else
            {
                Console.WriteLine("Nothing heppend");
            }
        }
    }
}
