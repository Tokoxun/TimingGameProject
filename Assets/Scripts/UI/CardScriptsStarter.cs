using UnityEngine;

public class CardScriptsStarter : CardScripts
{
    public EffectChoiceStarter choosing;
    public EffectTag chosenStarter;

    public new void SelectedCard()
    {
        if(!Chosen)
        {
            Chosen =true;
            choosing.startEffect = chosenStarter.ActivateEffect;
        }
        else if(Chosen)
        {
            Chosen = false;
            choosing.startEffect = null;
        }
    }
}
