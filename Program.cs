//main
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommedation(stadium);
DisplayStadiumDetails(stadium, game);

//end


static string GetEnjoymentLevel()
{
   Console.WriteLine("Enter your preferred level of enjoyment(Boring,Average,Fun,Epic)");
   string enjoymentLevel= Console.ReadLine().ToLower();
   if (enjoymentLevel == "boring" || enjoymentLevel == "average" || enjoymentLevel == "fun" || enjoymentLevel == "epic")
   {
    return enjoymentLevel;
   }
   else
   {
    Console.WriteLine("Invalid Input");
    return GetEnjoymentLevel();
   }

}


static string GetStadiumRecommendation(string enjoymentLevel)
{
    switch(enjoymentLevel)
    {

    case "boring":
    return "Neyland Stadium";
    break;

    case "average":
    return "Jordan-Hare Stadium";
    break;
    
    case "fun":
    return "Tiger Stadium";
    break;
    
    case "epic":
    return "Saban Field at Bryant-Denny Stadium";
    break;
    default:
    return "Unknown";
    }
}
static string GetGameRecommedation(string stadium)
{
    switch(stadium)
    {
        case "Neyland Stadium":
        return "Kent State";
        break;

        case "Jordan-Hare Stadium":
        return "Kentucky";
        break;

        case "Tiger Stadium":
        return "Alabama";
        break;

        case "Saban Field at Bryant-Denny Stadium":
        return "Auburn";
        break;
        
        default:
        return "Unknown";
    }
}

static void DisplayStadiumDetails(string stadium, string game)
{
    Console.WriteLine("Based on your choice, you should visit " + stadium +" and watch " + game + " play football.");
}

