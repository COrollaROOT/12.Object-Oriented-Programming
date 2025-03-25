using System.ComponentModel;

namespace 객체지향
{
    internal class Program
    {

        class Human  
        {
            string name;
            int age;
            float height;
        }

        class Player // 가지고 있는 정보 = (변수{명사}) class를 통해 객체들의 설계도 구성 (붕어빵 틀)
        {
            private int level; // private 사적의 / 외부에서 사용할수 없다
            public int attack; // public 공공의 / 외부에서 사용할수 있다

            public void Attack(Monster monster) // 할수 있는 행동 = (함수{동사})
            {

            }

        }

        class Monster
        {
            private int hp;


        }

        static void Main(string[] args)
        {
            Player player = new Player(); // class를 통해 만든 설계도를 토대로 활용할 구성품(인스턴스) = new 구현 (붕어빵)
            Monster monster = new Monster();

            player.Attack(monster); // player Attack monster = 플레이어가 몬스터를 공격한다

            
        }
    }
}



//     internal class Program
// {
//     class Player
//     {
//         // 변수(명사) : 정보
//         private int level = 1;
//         private int attackPoint = 10;
// 
//         // 함수(동사) : 행동
//         public void Attack(Monster monster)
//         {
//             Console.WriteLine(""플레이어가 몬스터를 공격합니다"");
//             monster.TakeHit(attackPoint);
//             Console.WriteLine(""플레이어가 공격을 마칩니다."");
//         }
//     }
// 
//      class Monster
//      {
//          private int hp = 20;
//  
//          public void TakeHit(int attackPoint)
//          {
//              Console.WriteLine(""몬스터가 피격을 받습니다."");
//              hp -= attackPoint;
//              Console.WriteLine(""몬스터의 현재 체력은 { 0}
//              입니다."", hp);
//  
//              if (hp <= 0)
//              {
//                  Die();
//              }
//          }
//  
//          private void Die()
//          {
//              Console.WriteLine(""몬스터가 쓰러집니다."");
//          }
//      }
//  
//  
//      static void Main(string[] args)
//      {
//          Player player = new Player();
//          Monster monster = new Monster();
//  
//          player.Attack(monster);     // player attack monster
//          player.Attack(monster);     // player attack monster
//  
//      }
//  }

// 메모리 memory
// 프로그램을 처리하기 위해 필요한 정보를 저장하는 기억장치
// 프로그램은 메모리에 저장한 정보를 토대로 명령들을 수행함

// 메모리 구조
// 프로그램은 효율적안 메모리 관리를 위해 메모리 영역을 구분
// 데이터는 각 열할마다 저장되는 영역을 달리하여 접근범위, 생존범위 등을 관리

// 메모리의 구조
// 코드영역 - 실행할 프로그램의 코드
// 프로그램이 실행할 코드가 정장되는 영역
// 데이터가 변경되지 않은 읽기 전용 데이터

// 데이터 영역 - 전역 변수, 정적 변수
// 정적변수가 정장되는 영역
// 프로그램 시작시 할당되며 종료시 삭제됨

// 힙 영역 - 사용자의 동적 할당
// 클래스 인스턴스가 저장되는 영역
// 인스턴스를 생성시 할당되며 더이상 사용하지 않을시 자동으로 삭제됨
// 인스턴스를 참조하고 있는 변수가 없을때 더이상 사용하지 않는다고 판단
// 더이상 사용하지 않는 인스턴스는 가비지 컬랙터가 특정 타이밍에 수거해감

// 스택 영역 - 지역변수, 매개변수
// 지역변수와 매개변수가 저장되는 영역
// 함수의 호출시 할당되며 종료시 삭제됨


//  class ClassType
//  {
//      public int value;
//  }
//  
//  struct StructType
//  {
//      public int value;
//  }
//  
//  static void Main(string[] args)
//  {
//      // 클래스는 참조 (주소 : 바로가기)
//      ClassType type = new ClassType();
//      ClassType addressCopy = instance;  // 주소를 복사해서 같은 인스턴스를 공유해서 쓴다.
//  
//      //구조체는 값 (데이터 저장소)
//      StructType localValue;
//      localValue.value = 10;
//      StructType valueCopy = localValue; // 값을 복사해서 각자 같은 값을 독립적으로 갖는다.
//  }


//  public class Monster
//  {
//      public string name;
//      public int hp;
//  
//  
//      // 클래스 생성자
//      // 반환형이 없는 클래스이름의 함수를 생성자라 하며 클래스의 인스턴스를 만들 때 호출되는 역활로 사용
//      // 인스턴스의 생성자는 new 키워드를 통해서 사용
//  
//      public Monster()
//      {
//          Console.WriteLine("몬스터 생성자");
//          name = "몬스터";
//          hp = 100;
//      }
//  }
//  
//  static void Main(string[] args)
//  {
//      Monster monster = new Monster();
//  }


﻿namespace _09._OOP
{
    internal class Program
    {
        /****************************************************************
         * 객체지향 프로그래밍 (Object Oriented Programming)
         *
         * 프로그램 설계방법론이자 개념의 일종
         * 프로그램을 서로 상호작용하는 객체를 기본 단위로 구성하는 방식
         ****************************************************************/

        // <절차지향과 객체지향>
        // 절차지향 : 프로그램의 순차적인 처리를 위주로 설계하는 방법론
        // 객체지향 : 서로 상호작용하는 객체를 기본 단위로 구성하는 방법론


        // <객체지향의 등장배경>
        // 물리적인 하드웨어의 발전이 빠르게 진행되었으며, 소프트웨어의 중요성이 빠르게 올라감
        // 기존 절차지향의 방식으로는 복잡한 구조에 대한 설계가 힘들어졌으며 객체지향의 방식이 대안이 됨


        // <객체지향의 장단점>
        // 장점 :   1. 객체단위로 관리하기 때문에 디버깅이 유리함
        //          2. 클래스 단위로 모듈화 시켜 관리하므로 대규모 프로젝트에 적합
        //          3. 코드의 재사용성이 좋음
        // 단점 :   1. 설계에 시간이 많이 소비되며 신중해야함


        // <객체지향 4특징>
        // 캡슐화  : 객체를 상태와 기능으로 묶는 것을 의미하며, 객체의 내부 상태와 기능을 숨기고, 허용한 상태와 기능만의 액세스 허용
        // 다형성  : 부모클래스의 함수를 자식클래스에서 재정의하여 자식클래스의 다른 반응을 구현
        // 추상화  : 관련 특성 및 엔터티의 상호 작용을 클래스로 모델링하여 시스템의 추상적 표현을 정의
        // 상속    : 부모클래스의 모든 기능을 가지는 자식클래스를 설계하는 방법


        // <객체설계 5원칙>
        // (S)단일 책임 원칙        : 객체는 오직 하나의 책임을 가져야 함
        // (O)개방 폐쇄 원칙        : 객체는 확장에 대해서는 개방적이고 수정에 대해서는 폐쇄적이어야 함
        // (L)리스코프 치환 원칙    : 자식클래스는 언제나 자신의 부모클래스를 대체할 수 있어야 함
        // (I)인터페이스 분리 원칙  : 인터페이스는 작은 단위들로 분리시켜 구성하며, 사용하지 않는 함수는 포함하지 않아야 함
        // (D)의존성 역전 원칙      : 객체는 하위클래스(상위클래스를 구현한 객체)보다 상위클래스(추상성이 높은 상위 개념)에 의존해야함


        class Driver
        {
            public string name;

            public void Ride(Vehicle vehicle)
            {
                Console.WriteLine($"{this.name} 이/가 {vehicle.name} 을 운전합니다.");
                vehicle.Move();
            }
        }

        class Vehicle
        {
            public string name;
            public int speed = 0;

            public void Move()
            {
                speed += 10;
                Console.WriteLine($"{name} 의 속도가 {speed} 으로 증가합니다.");
            }
        }

        void Main()
        {
            Driver driver = new Driver() { name = "드라이버" };         // 드라이버 객체 생성
            Vehicle motorBike = new Vehicle() { name = "오토바이" };    // 오토바이 객체 생성

            driver.Ride(motorBike);     // 드라이버 객체가 Ride 기능으로 오토바이 객체와 상호작용
        }


        static void Main(string[] args)
        {
            
        }
    }
}
