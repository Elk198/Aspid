using System.Collections.Generic;

namespace Aspid.Modules.Languages
{
    public class English
    {
        public static readonly Dictionary<int, string> texts = new Dictionary<int, string>
        {
            [0] = "You take the revolver in your hand",
            [1] = "You check the cylinder and spin it",
            [2] = "You put the gun to your head...",
            [3] = "The shot rings out and body of ",
            [4] = " falls on the floor loudly.",
            [5] = "Click! Nothing happened! Pass the gun to someone else. Let them test their luck.",

            [6] = "It's forbidden to give guns to criminals",
            [7] = "Dead men don't play with luck",

            [8] = "*YOU CANNOT RID OF THE ASPIDS THIS WAY*",
            [9] = "Suicide? Not like this.",
            [10] = "Don't offer guns to the dead.",
            [11] = "It's forbidden to give guns to criminials.",
            [12] = "You are shooting at a corpse. Was death not enough?",

            [13] = "You shot ",
            [14] = "Miss! What a shame ",

            [15] = " people were killed..\n\nTotal amount dead: ",
            [16] = " times \n",

            [17] = "Suddenly, Kingsmoulds burst into the room, take away ",
            [18] = "'s gun, watch them fall to their feet, claw the room and the furniture, and leave.",

            [19] = "No characters.",
            [20] = "\n\n By ",

            [21] = "User doesn't have any characters.",
            [22] = "**User characters**",

            [23] = "Character **",
            [24] = "** has been added",

            [25] = "*** has been deleted",

            [26] = "** has been updated",

            [27] = "No characters on the server.",

            [28] = "**Characters**",

            [29] = "Input must be less than 100.",
            [30] = "Input must be 2 or higher.",
            [31] = "\n \n You get `",

            [32] = "***BOT COMMANDS***",
            [33] = "Page ",

            [34] = "Use this link to add this bot to your server.",

            [35] = "**VOTE**",
            [36] = " - if you are for this \n",
            [37] = " - if you are against this",

            [38] = "**ABOUT**",
            [39] = "**Primal Aspid** - [Opensorce](https://github.com/xentellion/Aspid) **Discord** messenger bot on **C#** language on **.NET Core** platform",

            [40] = "**SERVER INFO**",
            [41] = "Server **",
            [42] = "** was created on ",
            [43] = "Totally on server **",
            [44] = "** users, **",
            [45] = "** roles and **",
            [46] = "** channels\n\n",

            [47] = "Bot has been disabled.",
            [48] = "Bot has been enabled.",
            [49] = "Bot has been disabled for technical reasons.",

            [50] = "minutes",
            [51] = "hours",
            [52] = "days",
            [53] = "weeks",
            [54] = "years",
            [55] = " *has been muted for ",
            [56] = "unknown reason.",
            [57] = "ATTENTION",
            [58] = "You have been muted on **",
            [59] = "** server for **",
            [60] = "** for ",

            [61] = "Aspids don't let dead men pet them.",
            [62] = "You didn't ask anything.",

            [63] = "** has arrived at the server.",
            [64] = "Someone has appeared from the fog...",
            [65] = "** left the server.",
            [66] = "Someone's steps disminished in the distance...",
        };

        public static readonly string[] asks =
        {
            "Undoubtedly.",
            "Sure.",
            "No doubt.",
            "Certainly.",
            "You can be sure about it.",
            "I will die if this is wrong.",
            "I think so.",
            "Aspid Community says 'Yes'.",
            "Most likely.",
            "Good prospects.",
            "Signs say 'yes'.",
            "Yes.",
            "I am sure.",
            "Question is unclear.",
            "Ask me later.",
            "It's better not to know the answer.",
            "Do you want me to die answering this question?!",
            "Not right now.",
            "Pet me first.",
            "I don't want to answer.",
            "Don't you dare.",
            "I say 'no'.",
            "Aspid Community says 'No'.",
            "Not very good prospects.",
            "Highly doubtful.",
            "No.",
            "Don't make me angry with this question.",
        };

        public static readonly string[] pets =
        {
            "Aspid didn't like your petting and spat at you. You died.",
            "\"Be careful with my wings\"",
            "\"I want some more\"",
            "Aspid wants more petting",
            "Aspid flew away: you touched his wings",
            "Aspid liked petting and wants more",
            "Aspid wants you to rub his back",
            "*Happy hiss*"
        };
    }
}
