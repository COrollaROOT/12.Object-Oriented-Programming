using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 객체지향
{
    public class Player // 클래스 소스 코드는 따로 파일을 만들어 관리
    {
        public int ap = 10;

        public void Attack(Monster monster)
        {
            monster.TakeHit(ap);
        }
    }
}
