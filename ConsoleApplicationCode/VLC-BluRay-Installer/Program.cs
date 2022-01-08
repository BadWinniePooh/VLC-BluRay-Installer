// See https://aka.ms/new-console-template for more information

global using System.Security.Principal;
using VLC_BluRay_Installer;

Statics.EnsureAdminRights();

Statics.Copyright();
while (true)
{
    Statics.Menue();
}

