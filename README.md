# ADReplStatus

Active Directory Replication Status Tool, aka ADREPLSTATUS

Joseph Ryan Ries - 2023

<img alt="GitHub all releases" src="https://img.shields.io/github/downloads/ryanries/ADReplStatus/total">


**This project is NOT supported or endorsed by Microsoft. I work for Microsoft, but this is a personal project.**

**This tool is still very early in development. Right now I need beta testers to report bugs, submit feature requests, and send me screenshots of ADREPLSTATUS that I can post here in this README to spruce up the page.**

I am rebuilding the AD Replication Status Tool. Here are my reasons:

- The old version of the tool had a time bomb in it - an expiring SSL certificate - that rendered the app
unusable sometime around September 2022. Only through great effort internally were we able to periodically renew
this certificate and republish the app, and the app was architected in such a way that excising the signing 
certificate check was more work than just rewriting the whole thing. (I know about the Sirona DLL hack, but still.)

- The old tool had no active maintainers and no one who was still around was familiar with the app's internals or source code.

- The old tool was showing its age... I mean, that Office-style ribbon was straight out of the Windows Vista era, was it not?
Plus it contained a bunch of outdated TechNet links. You might argue that WinForms is similarly old-fashioned, but I just so 
happen to think WinForms is and always was PEAK Windows UI.

- Now we can maintain and improve this tool together. The Active Directory community.

Here are some screenshots of what the tool looks like currently:

![screenshot1](https://user-images.githubusercontent.com/15063294/212465477-8f244640-6796-4afb-ba9a-1b98acda279c.png)

![screenshot2](https://user-images.githubusercontent.com/29166333/212477765-3e4b714d-2ae0-4c78-b73e-cf13671f8eb5.png)

![screenshot3](screenshot01.png)

This project currently targets .NET Framework 4.8.

This project uses ObjectListView.Official 2.9.1 by Phillip Piper. This can be installed as a NuGet package directly from within
the Visual Studio IDE, (which is what I did,) and it can also be downloaded separately here: https://objectlistview.sourceforge.net/cs/index.html