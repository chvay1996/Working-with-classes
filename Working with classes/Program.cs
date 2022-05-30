using System;

namespace Working_with_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(1, 200, 100, 25, 50);
            Player player2 = new Player(2, 150, 80, 40, 30);
            Player player3 = new Player(3);

            player1.ShowInformation();

            player2.ShowInformation();

            player3.ShowInformation();
        }
    }

    class Player
    {
        public byte PlayerNamber;
        public byte Life;
        public byte Mana;
        public byte Damage;
        public byte Armor;

        public void ShowInformation()
        {
            Console.WriteLine($"Игрока № {PlayerNamber}\nЖизнь {Life}\nМана {Mana}\nУрон {Damage}\nСнаряжение {Armor}\n");
        }

        public Player(byte playerNamber ,byte life, byte mana, byte damage, byte armor)
        {
            PlayerNamber = playerNamber;
            Life = life;
            Mana = mana;
            Damage = damage;
            Armor = armor;
        }
        
        public Player(byte playerNamber)
        {
            PlayerNamber = playerNamber;
            Life = 250;
            Mana = 125;
            Damage = 25;
            Armor = 10;
        }
    }
}
/*Задача:
Создать класс игрока, с полями содержащими информацию об игроке и методом, который выводит информацию на экран.

В классе обязательно должен быть конструктор*/