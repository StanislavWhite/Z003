int distance = 10000, firstspeed = 1, secondspeed = 2, dogspeed = 5, count = 0;
bool onefriend = true;

while (distance <= 10)
{
if (onefriend = true)
{
    distance=dogspeed/distance-(firstspeed+secondspeed);
    onefriend = false;
    count = count + 1;
}
else if (onefriend = false)
{
    distance=dogspeed/distance-(firstspeed+secondspeed);
    onefriend = true;
    count = count + 1;
}
}

Console.WriteLine(count);