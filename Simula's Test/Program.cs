void ChestMessage(ChestState chestState)
{
    Console.Write($"The chest is {chestState}. What do you want to do? " );
}

UserChestActions ChestOption()
{
    bool validChoice = false;

    UserChestActions action = UserChestActions.unlocks;

    while (!validChoice)
    {
        string userChoice = Console.ReadLine();

        if (userChoice == "unlock")
        {
            validChoice = true;
            action = UserChestActions.unlocks;
        }
        else if (userChoice == "lock")
        {
            validChoice = true;
            action = UserChestActions.locks;
        }
        else if (userChoice == "open")
        {
            validChoice= true;
            action = UserChestActions.opens;
        }
        else if (userChoice == "close")
        {
            validChoice= true;
            action = UserChestActions.closes;
        }
    }
    return action;
}

void CheckChestState()
{
    ChestState chestState = ChestState.locked;
    while (true)
    {
        ChestMessage(chestState);
        UserChestActions userAction = ChestOption();
        
        if(chestState == ChestState.locked)
        {
            if (userAction == UserChestActions.unlocks)
            {
                chestState = ChestState.closed;
            }
        }
        if(chestState  == ChestState.closed)
        {
            if (userAction == UserChestActions.opens)
            {
                chestState = ChestState.open;
            }
            if (userAction == UserChestActions.locks)
            {
                chestState = ChestState.locked;
            }
        }
        if(chestState == ChestState.open)
        {
            if (userAction == UserChestActions.closes)
            {
                chestState = ChestState.closed;
            }
        }

    }

}

CheckChestState();


enum ChestState { open, closed, locked };
enum UserChestActions { opens, closes, locks, unlocks}