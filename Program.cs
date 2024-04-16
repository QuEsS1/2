using System.Diagnostics;
using System.Runtime.CompilerServices;

try
{
    IAnimal[] animals= new IAnimal[2];
    animals[0]= new Dolphin(200, 0);
    animals[1]= new Pinguin(40, 1);
    animals[0].Move();
    animals[0].Print();
    animals[1].Move();
    animals[1].Print();
}catch(Exception exp)
{
    Console.WriteLine(exp.Message);
}
interface IAnimal
{
    void Move();
    void Print();
}
abstract class Animal : IAnimal
{
    public abstract void Move();
    public abstract void Print();
    protected uint weight;// вес
}
abstract class Fish : Animal
{
    protected string habitat;// место обитания
}
abstract class Bird : Animal
{
    protected uint wingspan;// размах крыла
}
abstract class Mammal : Animal
{
    protected uint How_many_legs;
}
class  Pinguin : Bird
{
    public Pinguin(uint weight,  uint wingspan)
    {
        this.weight = weight;
        this.wingspan = wingspan;
    }
    public override void Move()
    {
        Console.WriteLine("Пингвин плывет если находится в воде, идет если находится на суше");
    }
    public override void Print()
    {
        Console.WriteLine("Вес: "+weight+"кг Размах крыльев: "+ wingspan+"м");
    }
}
class Dolphin : Mammal
{
    public Dolphin(uint weight, uint How_many_leg)
    {
        this.weight = weight;
        this.How_many_legs = How_many_leg;
    }
    public override void Move()
    {
        Console.WriteLine("Дельфин плывет");
    }
    public override void Print()
    {
        Console.WriteLine("Вес: " + weight + "кг Количество ног: " + How_many_legs);
    }
}