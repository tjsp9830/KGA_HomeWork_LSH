namespace Day_11_OOP
{

    #region 수업내용
    //internal class Program
    //{

    //    enum CarType { Truck, Bus }


    //    // 어떤 속성? 정보?
    //    class Car
    //    {
    //        public string name;
    //        public float speed;
    //        public CarType type;

    //        private bool turnOn;
    //        public int oilAmount;



    //        public void Drive()
    //        {
    //            Console.WriteLine($"{name} 이름의 차의 속도를 높입니다.");
    //            speed += 10;
    //        }

    //        public void Stop()
    //        {
    //            Console.WriteLine($"{name} 이름의 차를 멈춥니다.");
    //            speed = 0;
    //        }

    //        public void TurnOn()
    //        {
    //            if (oilAmount > 0)
    //            {
    //                Console.WriteLine("시동이 걸렸당");
    //                turnOn = true;
    //            }
    //            else
    //            {
    //                Console.WriteLine("기름이 없어서 시동이 안걸령");
    //            }

    //        }

    //        public void TurnOff()
    //        {
    //        }



    //    }


    //    class Player
    //    {
    //        private int hp = 100;

    //        public void TakeDamage(int damage)
    //        {

    //            Console.WriteLine($"플레이어가 {damage}의 데미지를 받았소!!");
    //            hp -= damage;
    //            Console.WriteLine($"플레이어의 체력이 {hp}가 되었소이다!!");


    //            if (hp <= 0)
    //            {
    //                Die();
    //            }
    //        }

    //        private void Die()
    //        {
    //            Console.WriteLine("플레이어 사망");
    //        }

    //    }


    //    class Monster
    //    {
    //        // 멤버변수를 선언 하는 단계에서 초기화 해줘도 되긴 한데, 이건 채신기술임.
    //        // 그래서인지 구조체에선 안됨. 선언할때 초기화 하려고 하면 생성자 쓰라고 꼽줌..
    //        public string name;
    //        public int power;
    //        public int hp;


    //        // 1-1. 매개변수 없으니 디폴트 초기화때 사용
    //        // 2-1. 생성자를 아예 안만들면 C#이 기본 생성자 밥상을 차려줌            
    //        public Monster() 
    //        {
    //            name = "몬스터";
    //            hp = 100;

    //        }

    //        // 1-2. 매개변수 넣으니 그대로 출력
    //        // 2-2. 근데 기본생성자 없이 매개변수 딸린 생성자 먼저 만들면 빨간줄!! (서순은 허용 안해줌)
    //        public Monster(string _name, int _hp) 
    //        {
    //            name = _name;
    //            hp = _hp;

    //        }


    //        public void Attack(Player player)
    //        {
    //            Console.WriteLine($"{name}(이)가 플레이어를 {power}만큼 때렸지롱");
    //            player.TakeDamage(power);
    //        }

    //        public void PrintInfo()
    //        {
    //            Console.WriteLine($"{name}이름의 몬스터: 현재체력 {hp}");
    //        }



    //    }



    //    static void Main(string[] args)
    //    {
    //        //string carName = "봉고";
    //        //float carSpeed = 0f;
    //        //CarType carType = CarType.Truck;


    //        //string playerName = "김전사";
    //        //float playerCritical = 0.3f;

    //        //// 절차지향: 내가 잠을 안자면 토마스와 친구들이 되어버림;;
    //        //DriveCar(playerName, ref playerCritical, carType);

    //        //// 객체지향
    //        //Car bongo = new Car();
    //        //bongo.name = "봉고";
    //        //bongo.speed = 0f; 
    //        //bongo.type = CarType.Truck;

    //        //bongo.Drive();
    //        //bongo.Stop();

    //        //// 불가능해짐!!
    //        //// playerName.Drive();

    //        //// 기름이 없는데도 시동이 켜지게 만들어 버릴수도.. ㅠㅠ
    //        //// 시동 온오프 데이터는 private로 두고, 시동거는 행위를 시행하게!!
    //        ////bongo.turnOn = true;
    //        //bongo.TurnOn();

    //        // 이렇게 담당자한테 일을 주자! 내가 다 하지 말고
    //        Player player = new Player();           // 객체가 인스턴스는 아니다
    //        Monster monster = new Monster();

    //        monster.power = 20;
    //        //player.TakeDamage(10); 는 되는데
    //        //Player.TakeDamage(10);은 안되는게 그 이유임. Player클래스는 플레이어를 만든게 아니고 그 설계도를 만든거니까
    //        monster.Attack(player);
    //        monster.Attack(player);
    //        monster.Attack(player);
    //        monster.Attack(player);
    //        monster.Attack(player);


    //        // 클래스는 객체만들기임. 객체의 설계도. 붕어빵 틀!! 
    //        // (구조체, 열거형 등도 똑같음. 그래서 꼭 한번 선언해줘야 되는거임)
    //        // 인스턴스가 실제로 객체 자체를 말함. 붕어빵!!
    //        // 엥 객체가 인스턴스는 아닌데 인스턴스는 객체임?

    //        Monster dragon = new Monster();
    //        dragon.name = "드래곤";
    //        dragon.power = 30;

    //        Monster orc = new Monster();
    //        dragon.name = "오크";
    //        dragon.power = 15;

    //        Monster silme = new Monster();
    //        dragon.name = "슬라임";
    //        dragon.power = 5;

    //        dragon.Attack(player);
    //        orc.Attack(player);
    //        silme.Attack(player);



    //        Monster monster1650 = new Monster("토실이", 1000);
    //        monster.PrintInfo();



    //    }





    //    static void DriveCar(string carName, ref float carSpeed, CarType carType)
    //    {

    //        Console.WriteLine($"{carName} 이름의 차의 속도를 높입니다.");
    //        carSpeed += 10;

    //    }

    //    static void StopCar(string carName, ref float carSpeed, CarType carType)
    //    {

    //        Console.WriteLine($"{carName} 이름의 차를 멈춥니다.");
    //        carSpeed = 0;

    //    }


    //}

    #endregion 수업내용


    #region 일반실습

    class Chracter
    {
        int level;
        int hp;
        float moveSpeed;
        int power;

        void MoveFront()
        {

        }

        void MoveBack()
        {

        }
        void TurnLeft()
        {

        }
        void TurnRight()
        {

        }

        void attack()
        {

        }

        void Hit()
        {

        }


    }


    internal class Program
    {

        static void Main(string[] args)
        {


        }

    }

    #endregion 일반실습

}
