using UnityEngine;

public class CardScriptsStarter : CardScripts
{
    public EffectChoiceStarter choosing;

    public new void SelectedCard()
    {
        if(!Chosen)
        {
            Chosen =true;
            choosing.startEffect = ActivateTag;
        }
        else if(Chosen)
        {
            Chosen = false;
            choosing.startEffect = null;
        }
    }

    public new void ActivateTag()
    {
        playerInventory.selectedTags.Add(chosenR);
    }
}
