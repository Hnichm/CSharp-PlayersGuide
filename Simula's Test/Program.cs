void ChestMessage(ChestState chestState)
{
    Console.Write($"The chest is {chestState}. What do you want to do? ");
}

UserChestActions ChestOption()
{
    while (true)
    {
        string userChoice = Console.ReadLine();

        switch (userChoice)
        {
            case "unlock":
                return UserChestActions.unlocks;
            case "lock":
                return UserChestActions.locks;
            case "open":
                return UserChestActions.opens;
            case "close":
                return UserChestActions.closes;
            default:
                Console.Write("Invalid choice. Try again: ");
                break;
        }
    }
}

void CheckChestState()
{
    ChestState chestState = ChestState.locked;
    while (true)
    {
        ChestMessage(chestState);
        UserChestActions userAction = ChestOption();

        switch (chestState)
        {
            case ChestState.locked:
                if (userAction == UserChestActions.unlocks)
                {
                    chestState = ChestState.closed;
                }
                break;
            case ChestState.closed:
                if (userAction == UserChestActions.opens)
                {
                    chestState = ChestState.open;
                }
                else if (userAction == UserChestActions.locks)
                {
                    chestState = ChestState.locked;
                }
                break;
            case ChestState.open:
                if (userAction == UserChestActions.closes)
                {
                    chestState = ChestState.closed;
                }
                break;
        }
    }
}

CheckChestState();

enum ChestState { open, closed, locked };
enum UserChestActions { opens, closes, locks, unlocks }
