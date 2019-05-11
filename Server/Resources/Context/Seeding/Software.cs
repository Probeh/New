using System.Collections.Generic;
using Server.Resources.Enums;
using Server.Resources.Models;

namespace Server.Resources.Context.Seeding
{
    public partial class DataSeeder
    {
        public List<Software> SeedSoftware()
        {
            return new List<Software>
            {
                new Software
                {
                    Key = SoftwareKey.Babylon,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.Babylon,
                        Name = "Babylon",
                        Title = "Babylon Translator",
                        Image = "http://img.babylon.com/site/images/mediaroom/mobile/bforb_hires.png",
                        Summary = "Babylon is a computer dictionary and translation program developed by the Israeli company Babylon Software Ltd. based in the city of Or Yehuda. The company was established in 1997 by the Israeli entrepreneur Amnon Ovadia. Its IPO took place ten years later. It is considered a part of Israel's Download Valley, a cluster of software companies monetizing free software downloads through adware. Babylon includes in-house proprietary dictionaries, as well as community-created dictionaries and glossaries. It is a tool used for translation and conversion of currencies, measurements and time, and for obtaining other contextual information. The program also uses a text-to-speech agent, so users hear the proper pronunciation of words and text. Babylon has developed 36 English-based proprietary dictionaries in 21 languages. In 2008–2009, Babylon reported earnings of 50 million NIS through its collaboration with Google. Between 2010 and 2013, Babylon became infamous for demonstrating questionable behavior typical of malware: A Babylon Toolbar bundled with Babylon and other software, has been widely identified as a browser hijacker that is very easy to install inadvertently and unnecessarily difficult to remove. This eventually lead to Google terminating its agreement with Babylon Ltd. in 2013"
                },
                new Software
                {
                    Key = SoftwareKey.CMD,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.Microsoft,
                        ProductKey = ProductKey.MSWindows,
                        Name = "CMD",
                        Title = "Command Prompt",
                        Image = "http://icons.iconarchive.com/icons/ampeross/ampola/256/cmd-icon.png",
                        Summary = "CMD, cmd (after its command name) or cmd.exe (after its executable file name), also known as Command Prompt (after the default window title), is the command-line interpreter in the OS/2, eComStation, Windows NT, Windows CE, and ReactOS operating systems. It is the counterpart of COMMAND.COM in DOS and Windows 9x systems, and analogous to the Unix shells used on Unix-like systems. The initial version of cmd.exe for Windows NT was developed by Therese Stowell."
                },
                new Software
                {
                    Key = SoftwareKey.Chrome,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.Google,
                        Name = "Chrome",
                        Title = "Google Chrome",
                        Image = "http://icons.iconarchive.com/icons/google/chrome/128/Google-Chrome-icon.png",
                        Summary = "Google Chrome (commonly known simply as Chrome) is a cross-platform web browser developed by Google. It was first released in 2008 for Microsoft Windows, and was later ported to Linux, macOS, iOS, and Android. The browser is also the main component of Chrome OS, where it serves as the platform for web apps. Most of Chrome's source code comes from Google's open-source Chromium project, but Chrome is licensed as proprietary freeware. WebKit was the original rendering engine, but Google eventually forked it to create the Blink engine; all Chrome variants except iOS now use Blink. As of April 2019, StatCounter estimates that Chrome has a 70.05% worldwide browser market share on traditional PCs and 63.16% share across all platforms. Because of this success, Google has expanded the Chrome brand name to other products: Chrome OS, Chromecast, Chromebook, Chromebit, Chromebox, and Chromebase."
                },
                new Software
                {
                    Key = SoftwareKey.CitrixReceiver,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.Citrix,
                        Name = "Receiver",
                        Title = "Citrix Receiver",
                        Image = "http://icons.iconarchive.com/icons/papirus-team/papirus-apps/128/citrix-receiver-icon.png",
                        Summary = "Citrix Receiver is the client component of XenDesktop or XenApp. Devices with Receiver installed are able to access full desktops via XenDesktop or individual applications via XenApp from a centralized host, such as a server or cloud infrastructure. The product's intended users are employees. Citrix Receiver is not a standalone product and is included with XenApp and XenDesktop. Reviews praised Citrix Receiver's reasonably fast loading time and flexibility in allowing remote desktop access from many different computer and mobile platforms. However, reviewers also criticized the iPhone version of the software for the difficulty of formatting text and prolonged typing, tasks that normally required a keyboard and mouse. The iPad version had similar accessibility issues, and the performance of flash applications was very limited. As a remedy, Citrix developed a mouse for iOS devices."
                },
                new Software
                {
                    Key = SoftwareKey.DotNet,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.Microsoft,
                        Name = ".Net Framework",
                        Title = ".Net Framework Runtime",
                        Image = "https://seeklogo.com/images/M/microsoft-net-logo-631EFE744A-seeklogo.com.png",
                        Summary = ".NET Framework (pronounced as dot net) is a software framework developed by Microsoft that runs primarily on Microsoft Windows. It includes a large class library named as Framework Class Library (FCL) and provides language interoperability (each language can use code written in other languages) across several programming languages. Programs written for .NET Framework execute in a software environment (in contrast to a hardware environment) named the Common Language Runtime (CLR). The CLR is an application virtual machine that provides services such as security, memory management, and exception handling. As such, computer code written using .NET Framework is called managed code. FCL and CLR together constitute the .NET Framework. FCL provides user interface, data access, database connectivity, cryptography, web application development, numeric algorithms, and network communications. Programmers produce software by combining their source code with .NET Framework and other libraries. The framework is intended to be used by most new applications created for the Windows platform. Microsoft also produces an integrated development environment largely for .NET software called Visual Studio. .NET Framework began as proprietary software, although the firm worked to standardize the software stack almost immediately, even before its first release. Despite the standardization efforts, developers, mainly those in the free and open-source software communities, expressed their unease with the selected terms and the prospects of any free and open-source implementation, especially regarding software patents. Since then, Microsoft has changed .NET development to more closely follow a contemporary model of a community-developed software project, including issuing an update to its patent promising to address the concerns. .NET Framework led to a family of .NET platforms targeting mobile computing, embedded devices, alternative operating systems, and web browser plug-ins. A reduced version of the framework, .NET Compact Framework, is available on Windows CE platforms, including Windows Mobile devices such as smartphones. .NET Micro Framework is targeted at very resource-constrained embedded devices. Silverlight was available as a web browser plugin. Mono is available for many operating systems and is customized into popular smartphone operating systems (Android and iOS) and game engines. .NET Core targets the Universal Windows Platform (UWP), and cross-platform and cloud computing workloads."
                },
                new Software
                {
                    Key = SoftwareKey.Edge,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.Microsoft,
                        ProductKey = ProductKey.MSWindows,
                        Name = "Edge",
                        Title = "Microsoft Edge",
                        Image = "https://seeklogo.com/images/M/microsoft-edge-logo-755278AE39-seeklogo.com.png",
                        Summary = "Microsoft Edge is a web browser developed by Microsoft. It was first released for Windows 10 and Xbox One in 2015, then for Android and iOS in 2017. Edge includes integration with Cortana and has extensions hosted on the Microsoft Store. Unlike Internet Explorer, Edge does not support the legacy ActiveX and BHO technologies. Originally built with Microsoft's own EdgeHTML and Chakra engines, Edge is currently being rebuilt as a Chromium-based browser, using the Blink and V8 engines, based upon WebKit. As part of this big change, Microsoft intends to add support for Windows 7, 8, 8.1, and macOS."
                },
                new Software
                {
                    Key = SoftwareKey.InternetExplorer,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.Microsoft,
                        ProductKey = ProductKey.MSWindows,
                        Name = "Internet Explorer",
                        Title = "Internet Explorer",
                        Image = "http://www.iconarchive.com/show/cristal-intense-icons-by-tatice/Internet-Explorer-icon.html",
                        Summary = "Internet Explorer (formerly Microsoft Internet Explorer and Windows Internet Explorer, commonly abbreviated IE or MSIE) was a series of graphical web browsers (or as of 2019, a compatibility solution) developed by Microsoft and included in the Microsoft Windows line of operating systems, starting in 1995. It was first released as part of the add-on package Plus! for Windows 95 that year. Later versions were available as free downloads, or in service packs, and included in the original equipment manufacturer (OEM) service releases of Windows 95 and later versions of Windows. The browser is discontinued, but still maintained. Internet Explorer was once the most widely used web browser, attaining a peak of about 95% usage share by 2003. This came after Microsoft used bundling to win the first browser war against Netscape, which was the dominant browser in the 1990s. Its usage share has since declined with the launch of Firefox (2004) and Google Chrome (2008), and with the growing popularity of operating systems such as Android and iOS that do not run Internet Explorer. Estimates for Internet Explorer's market share are about 2.58% across all platforms or by StatCounter's numbers ranked 6th, while on desktop, the only platform it's ever had significant share (e.g., excluding mobile and Xbox) it's ranked 4th at 5.13%, after macOS's Safari; even only managing 3rd rank after Firefox when including IE's successor Edge share (others place IE 3rd with 8.44% after Firefox); as of May 2019 (browser market share is notoriously difficult to calculate). Microsoft spent over US$100 million per year on Internet Explorer in the late 1990s, with over 1,000 people involved in the project by 1999. Versions of Internet Explorer for other operating systems have also been produced, including an Xbox 360 version called Internet Explorer for Xbox and for platforms Microsoft no longer supports: Internet Explorer for Mac and Internet Explorer for UNIX (Solaris and HP-UX), and an embedded OEM version called Pocket Internet Explorer, later rebranded Internet Explorer Mobile made for Windows Phone, Windows CE, and previously, based on Internet Explorer 7 for Windows Mobile. On March 17, 2015, Microsoft announced that Microsoft Edge would replace Internet Explorer as the default browser on its Windows 10 devices (while support for older Windows has since been announced, as of 2019 Edge still has lower share than IE's, that's in decline). This effectively makes Internet Explorer 11 the last release (however IE 8, 9, and 10 also receive security updates as of 2019). Internet Explorer, however, remains on Windows 10 and Windows Server 2019 primarily for enterprise purposes. Since January 12, 2016, only Internet Explorer 11 has been supported. Support varies based on the operating system's technical capabilities and its support lifecycle. The browser has been scrutinized throughout its development for use of third-party technology (such as the source code of Spyglass Mosaic, used without royalty in early versions) and security and privacy vulnerabilities, and the United States and the European Union have alleged that integration of Internet Explorer with Windows has been to the detriment of fair browser competition."
                },
                new Software
                {
                    Key = SoftwareKey.ElevateMe,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.AMAT,
                        Name = "Elevate Me",
                        Title = "Local Admin Rights",
                        Image = "https://i.stack.imgur.com/5tspi.png",
                },
                new Software
                {
                    Key = SoftwareKey.Git,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.Git,
                        Name = "Git SCM",
                        Title = "Git Source Code Management (SCM)",
                        Image = "https://seeklogo.com/images/G/git-logo-CD8D6F1C09-seeklogo.com.png",
                        Summary = "Git is a distributed version-control system for tracking changes in source code during software development. It is designed for coordinating work among programmers, but it can be used to track changes in any set of files. Its goals include speed, data integrity, and support for distributed, non-linear workflows. Git was created by Linus Torvalds in 2005 for development of the Linux kernel, with other kernel developers contributing to its initial development. Its current maintainer since 2005 is Junio Hamano. As with most other distributed version-control systems, and unlike most client–server systems, every Git directory on every computer is a full-fledged repository with complete history and full version-tracking abilities, independent of network access or a central server."
                },
                new Software
                {
                    Key = SoftwareKey.GitBash,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.Git,
                        Name = "Git Bash",
                        Title = "Git Bash Terminal",
                        Image = "https://avatars2.githubusercontent.com/u/4571183?s=400&v=4",
                        Summary = "Git Bash is an application for Microsoft Windows environments which provides an emulation layer for a Git command line experience. Bash is an acronym for Bourne Again Shell. A shell is a terminal application used to interface with an operating system through written commands. Bash is a popular default shell on Linux and macOS. Git Bash is a package that installs Bash, some common bash utilities, and Git on a Windows operating system."
                },
                new Software
                {
                    Key = SoftwareKey.Java,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.Oracle,
                        Name = "Java JRE",
                        Title = "Java Runtime Environment (JRE)",
                        Image = "http://icons.iconarchive.com/icons/alecive/flatwoken/512/Apps-Java-icon.png",
                        Summary = "The Java Runtime Environment (JRE) released by Oracle is a freely available software distribution containing a stand-alone JVM (HotSpot), the Java standard library (Java Class Library), a configuration tool, and—until its discontinuation in JDK 9—a browser plug-in. It is the most common Java environment installed on personal computers in the laptop and desktop form factor. Mobile phones including feature phones and early smartphones that ship with a JVM are most likely to include a JVM meant to run applications targeting Micro Edition of the Java platform. Meanwhile, most modern smartphones, tablet computers, and other handheld PCs that run Java apps are most likely to do so through support of the Android operating system, which includes an open source virtual machine incompatible with the JVM specification. (Instead, Google's Android development tools take Java programs as input and output Dalvik bytecode, which is the native input format for the virtual machine on Android devices.)"
                },
                new Software
                {
                    Key = SoftwareKey.LotusNotes,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.IBM,
                        Name = "Lotus Notes",
                        Title = "IBM Lotus Notes",
                        Image = "http://www-10.lotus.com/ldd/insidelotusblog.nsf/dx/notes32b256p.png/$file/notes32b256p.png",
                        Summary = "IBM Notes (formerly Lotus Notes) and IBM Domino (formerly Lotus Domino) are the client and server, respectively, of a collaborative client-server software platform sold by IBM. IBM Notes provides business collaboration functions, such as email, calendars, to-do lists, contacts management, teamrooms, discussion forums, file sharing, microblogging, instant messaging, blogs, and user directories. IBM Notes can also be used with other IBM Domino applications and databases. IBM Notes 9 Social Edition removed integration with the office software package IBM Lotus Symphony, which had been integrated with the IBM Lotus Notes client in versions 8.x. Lotus Development Corporation originally developed Lotus Notes in 1989. IBM bought the Lotus Corporation in 1995 and it became known as the Lotus Development division of IBM. As of 2015 it forms part of the IBM Software and Systems Group under the name IBM Collaboration Solutions. IBM Notes is a desktop workflow application, commonly used in corporate environments for email and to create discussion groups, websites, document libraries, custom applications and business workflows."
                },
                new Software
                {
                    Key = SoftwareKey.MATLAB,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.Mathworks,
                        Name = "MATLAB",
                        Title = "Matrix Laboratory",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Matlab_Logo.png/128px-Matlab_Logo.png",
                        Summary = "MATLAB (matrix laboratory) is a multi-paradigm numerical computing environment and proprietary programming language developed by MathWorks. MATLAB allows matrix manipulations, plotting of functions and data, implementation of algorithms, creation of user interfaces, and interfacing with programs written in other languages, including C, C++, C#, Java, Fortran and Python. Although MATLAB is intended primarily for numerical computing, an optional toolbox uses the MuPAD symbolic engine, allowing access to symbolic computing abilities. An additional package, Simulink, adds graphical multi-domain simulation and model-based design for dynamic and embedded systems. As of 2018, MATLAB has more than 3 million users worldwide. MATLAB users come from various backgrounds of engineering, science, and economics."
                },
                new Software
                {
                    Key = SoftwareKey.PowerShell,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.Microsoft,
                        ProductKey = ProductKey.MSWindows,
                        Name = "PowerShell",
                        Title = "Windows Powershell",
                        Image = "https://cdn.iconscout.com/icon/free/png-128/powershell-2-569189.png",
                        Summary = "PowerShell is a task automation and configuration management framework from Microsoft, consisting of a command-line shell and associated scripting language. Initially a Windows component only, known as Windows PowerShell, it was made open-source and cross-platform on 18 August 2016 with the introduction of PowerShell Core. The former is built on .NET Framework while the latter on .NET Core. In PowerShell, administrative tasks are generally performed by cmdlets (pronounced command-lets), which are specialized .NET classes implementing a particular operation. These work by accessing data in different data stores, like the file system or registry, which are made available to PowerShell via providers. Third-party developers can add cmdlets and providers to PowerShell. Cmdlets may be used by scripts and scripts may be packaged into modules. PowerShell provides full access to COM and WMI, enabling administrators to perform administrative tasks on both local and remote Windows systems as well as WS-Management and CIM enabling management of remote Linux systems and network devices. PowerShell also provides a hosting API with which the PowerShell runtime can be embedded inside other applications. These applications can then use PowerShell functionality to implement certain operations, including those exposed via the graphical interface. This capability has been used by Microsoft Exchange Server 2007 to expose its management functionality as PowerShell cmdlets and providers and implement the graphical management tools as PowerShell hosts which invoke the necessary cmdlets. Other Microsoft applications including Microsoft SQL Server 2008 also expose their management interface via PowerShell cmdlets. PowerShell includes its own extensive, console-based help (similar to man pages in Unix shells) accessible via the Get-Help cmdlet. Local help contents can be retrieved from the Internet via Update-Help cmdlet. Alternatively, help from the web can be acquired on a case-by-case basis via the -online switch to Get-Help."
                },
                new Software
                {
                    Key = SoftwareKey.PulseSecure,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.PulseSecure,
                        Name = "Pulse Secure",
                        Title = "Pulse Secure VPN",
                        Image = "https://pbs.twimg.com/profile_images/697619008942571520/HRnoSfVy_400x400.png",
                        Summary = "PowerShell is a task automation and configuration management framework from Microsoft, consisting of a command-line shell and associated scripting language. Initially a Windows component only, known as Windows PowerShell, it was made open-source and cross-platform on 18 August 2016 with the introduction of PowerShell Core. The former is built on .NET Framework while the latter on .NET Core. In PowerShell, administrative tasks are generally performed by cmdlets (pronounced command-lets), which are specialized .NET classes implementing a particular operation. These work by accessing data in different data stores, like the file system or registry, which are made available to PowerShell via providers. Third-party developers can add cmdlets and providers to PowerShell. Cmdlets may be used by scripts and scripts may be packaged into modules. PowerShell provides full access to COM and WMI, enabling administrators to perform administrative tasks on both local and remote Windows systems as well as WS-Management and CIM enabling management of remote Linux systems and network devices. PowerShell also provides a hosting API with which the PowerShell runtime can be embedded inside other applications. These applications can then use PowerShell functionality to implement certain operations, including those exposed via the graphical interface. This capability has been used by Microsoft Exchange Server 2007 to expose its management functionality as PowerShell cmdlets and providers and implement the graphical management tools as PowerShell hosts which invoke the necessary cmdlets. Other Microsoft applications including Microsoft SQL Server 2008 also expose their management interface via PowerShell cmdlets. PowerShell includes its own extensive, console-based help (similar to man pages in Unix shells) accessible via the Get-Help cmdlet. Local help contents can be retrieved from the Internet via Update-Help cmdlet. Alternatively, help from the web can be acquired on a case-by-case basis via the -online switch to Get-Help."
                },
                new Software
                {
                    Key = SoftwareKey.RSAToken,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.RSA,
                        ProductKey = ProductKey.RSASecurID,
                        Name = "RSA Token",
                        Title = "RSA SecurID Soft Token",
                        Image = "https://seeklogo.com/images/R/rsa-logo-BAE738ADB8-seeklogo.com.png",
                        Summary = "The RSA SecurID authentication mechanism consists of a token — either hardware (e.g. a key fob) or software (a soft token) — which is assigned to a computer user and which creates an authentication code at fixed intervals (usually 60 seconds) using a built-in clock and the card's factory-encoded almost random key (known as the seed). The seed is different for each token, and is loaded into the corresponding RSA SecurID server (RSA Authentication Manager, formerly ACE/Server) as the tokens are purchased. On-demand tokens are also available, which provide a tokencode via email or SMS delivery, eliminating the need to provision a token to the user. The token hardware is designed to be tamper-resistant to deter reverse engineering. When software implementations of the same algorithm (software tokens) appeared on the market, public code had been developed by the security community allowing a user to emulate RSA SecurID in software, but only if they have access to a current RSA SecurID code, and the original 64-bit RSA SecurID seed file introduced to the server. Later, the 128-bit RSA SecurID algorithm was published as part of an open source library. In the RSA SecurID authentication scheme, the seed record is the secret key used to generate one-time passwords. Newer versions also feature a USB connector, which allows the token to be used as a smart card-like device for securely storing certificates."
                },
                new Software
                {
                    Key = SoftwareKey.VisualStudio,
                        PlatformKey = PlatformKey.Desktop,
                        OSystemKey = OSystemKey.Windows,
                        CompanyKey = CompanyKey.Microsoft,
                        Name = "Visual Studio",
                        Title = "Microsoft Visual Studio",
                        Image = "http://icons.iconarchive.com/icons/dakirby309/simply-styled/128/Microsoft-Visual-Studio-icon.png",
                        Summary = "Microsoft Visual Studio is an integrated development environment (IDE) from Microsoft. It is used to develop computer programs, as well as websites, web apps, web services and mobile apps. Visual Studio uses Microsoft software development platforms such as Windows API, Windows Forms, Windows Presentation Foundation, Windows Store and Microsoft Silverlight. It can produce both native code and managed code. Visual Studio includes a code editor supporting IntelliSense (the code completion component) as well as code refactoring. The integrated debugger works both as a source-level debugger and a machine-level debugger. Other built-in tools include a code profiler, forms designer for building GUI applications, web designer, class designer, and database schema designer. It accepts plug-ins that enhance the functionality at almost every level—including adding support for source control systems (like Subversion and Git) and adding new toolsets like editors and visual designers for domain-specific languages or toolsets for other aspects of the software development lifecycle (like the Team Foundation Server client: Team Explorer). Visual Studio supports 36 different programming languages and allows the code editor and debugger to support (to varying degrees) nearly any programming language, provided a language-specific service exists. Built-in languages include C, C++, C++/CLI, Visual Basic .NET, C#, F#, JavaScript, TypeScript, XML, XSLT, HTML, and CSS. Support for other languages such as Python, Ruby, Node.js, and M among others is available via plug-ins. Java (and J#) were supported in the past. The most basic edition of Visual Studio, the Community edition, is available free of charge. The currently supported Visual Studio version is 2019."
                }
            };
        }
    }
}