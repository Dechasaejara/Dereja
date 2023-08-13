using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
       if(knightIsAwake == true){
        return false;
       }
       return true;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if(knightIsAwake || archerIsAwake || prisonerIsAwake ){
            return true;
        }
        return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
       if(archerIsAwake== false && prisonerIsAwake == true ){
        return true;
       }
       return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(knightIsAwake==false && archerIsAwake ==false && petDogIsPresent== true && prisonerIsAwake== false){
            return true;
        }
        else if(archerIsAwake ==false && petDogIsPresent== true ){
            return true;
        }
        else if(knightIsAwake==false && archerIsAwake== false && prisonerIsAwake== true && petDogIsPresent== false){
            return true;
        }
        return false;
    }
}
