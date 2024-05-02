Hope I understood business requirement correctly, Each effect that can be applied to image represents a plugin to be added to ctalog.
All availables effects/plugins will be register during run time and will be shown to user, User will not have access to those objects because of abtraction and encaplulation principles.
Upon selecting an effect(s) based on that order they will be applied to image.

Considering that 'Radius' is for Blur effect
'Size' is for Resizing effect.
And the rest of the effects does not require parameters like, 'Convert to gray scale'.


IDesignProvider API is designed to be used by other .NET component who will be responsible of builidng UI.

It just has two methods GetAvailableEffectNames to show in UI
and to call Apply method after user selects effect with some parameters.
Note that the implementation details of IDesignProvider are not important and it is internal.


Every time when we want to add new effect, we will be needed to just
add new implementation of IPluginEffect interface and register it.

Note that I did not want to add Parameters to IEffectPlugin Apply() method, because each method can have different parameters,
I did not want one effect implementation to get redundant  parameters, that is why that part is missing.
