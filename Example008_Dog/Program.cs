int count = 0;
double distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
double time = 0;
while(distance > 10)
{
    if (friend == 1)
    {
        time = distance/(dogSpeed + firstFriendSpeed);
        friend = 2;
    }
    else
    {
        time = distance/(dogSpeed + secondFriendSpeed);
        friend = 1;
    }
    distance = distance - time*(secondFriendSpeed + firstFriendSpeed);
    count = count + 1;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз ");