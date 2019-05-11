using System.Collections.Generic;
using Server.Resources.Enums;
using Server.Resources.Models;

namespace Server.Resources.Context.Seeding
{
    public partial class DataSeeder
    {
        public List<Company> SeedCompanies()
        {
            return new List<Company>
            {
                new Company
                {
                    Key = CompanyKey.AMAT,
                        Name = "Applied Materials",
                        Image = "https://unicornbay.com/img/tlogos/US/amat.png",
                        Logo = "https://upload.wikimedia.org/wikipedia/he/thumb/0/03/Applied_Materials_Logo.svg/512px-Applied_Materials_Logo.svg.png",
                },
                new Company
                {
                    Key = CompanyKey.Adobe,
                        Name = "Adobe",
                        Image = "https://dev.w3.org/SVG/tools/svgweb/samples/svg-files/adobe.svg",
                        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Adobe_Systems_Logo_002.svg/512px-Adobe_Systems_Logo_002.svg.png"
                },
                new Company
                {
                    Key = CompanyKey.Babylon,
                        Name = "Babylon",
                        Image = "http://img.babylon.com/site/images/mediaroom/mobile/bforb_hires.png",
                        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Babylon_logo.png/512px-Babylon_logo.png"
                },
                new Company
                {
                    Key = CompanyKey.Cisco,
                        Name = "Cisco",
                        Image = "http://www.logospng.com/images/10/singapore-lacrosse-association-10935.png",
                        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/08/Cisco_logo_blue_2016.svg/512px-Cisco_logo_blue_2016.svg.png"
                },
                new Company
                {
                    Key = CompanyKey.Citrix,
                        Name = "Citrix",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2e/Citrix.svg/512px-Citrix.svg.png",
                        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2e/Citrix.svg/512px-Citrix.svg.png"
                },
                new Company
                {
                    Key = CompanyKey.Druva,
                        Name = "Druva",
                        Image = "https://uk.zones.com/wp-content/uploads/2019/02/druva.png",
                        Logo = "https://www.druva.com/images/logos/druva-logo-300.png"
                },
                new Company
                {
                    Key = CompanyKey.Dassault,
                        Name = "Dassault Systèmes",
                        Image = "https://seeklogo.com/images/D/Dassault_Systemes-logo-42B3E77AC0-seeklogo.com.png",
                        Logo = "https://upload.wikimedia.org/wikipedia/en/thumb/3/31/Dassault_Syst%C3%A8mes_logo.svg/512px-Dassault_Syst%C3%A8mes_logo.svg.png"
                },
                new Company
                {
                    Key = CompanyKey.Git,
                        Name = "Git",
                        Image = "https://seeklogo.com/images/G/git-logo-CD8D6F1C09-seeklogo.com.png",
                        Logo = "https://seeklogo.com/images/G/git-logo-F4A93DAA20-seeklogo.com.png"
                },
                new Company
                {
                    Key = CompanyKey.Google,
                        Name = "Google",
                        Image = "https://seeklogo.com/images/G/google-2015-logo-65BBD07B01-seeklogo.com.png",
                        Logo = "http://pngimg.com/uploads/google/google_PNG19644.png"
                },
                new Company
                {
                    Key = CompanyKey.IBM,
                        Name = "IBM",
                        Image = "https://seeklogo.com/images/I/ibm-logo-B51D5B3D7A-seeklogo.com.png",
                        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/51/IBM_logo.svg/512px-IBM_logo.svg.png"
                },
                new Company
                {
                    Key = CompanyKey.Intel,
                        Name = "Intel",
                        Image = "https://seeklogo.com/images/I/intel-logo-3F88C332C8-seeklogo.com.png",
                        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c9/Intel-logo.svg/512px-Intel-logo.svg.png"
                },
                new Company
                {
                    Key = CompanyKey.PulseSecure,
                        Name = "Pulse Secure",
                        Image = "https://pbs.twimg.com/profile_images/697619008942571520/HRnoSfVy_400x400.png",
                        Logo = "https://cdn-assets.indigenous.io/account_1329/Pulse-Secure-Logo-Dark_1504732155909.png"
                },
                new Company
                {
                    Key = CompanyKey.Lenovo,
                        Name = "Lenovo",
                        Image = "https://seeklogo.com/images/L/Lenovo-logo-C637A0E21A-seeklogo.com.png",
                        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Lenovo_logo_2015.svg/512px-Lenovo_logo_2015.svg.png"
                },
                new Company
                {
                    Key = CompanyKey.Logitech,
                        Name = "Logitech",
                        Image = "https://seeklogo.com/images/L/logitech-logo-39B3C24468-seeklogo.com.png",
                        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/Logitech_logo.svg/512px-Logitech_logo.svg.png"
                },
                new Company
                {
                    Key = CompanyKey.Mathworks,
                        Name = "Mathworks",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Matlab_Logo.png/200px-Matlab_Logo.png",
                        Logo = "https://static1.squarespace.com/static/5953d8c286e6c0b3b33858c0/t/5b85816f6d2a73fd18f599c9/1535476109601/Mathworks+Logo.png?format=512w"
                },
                new Company
                {
                    Key = CompanyKey.Microsoft,
                        Name = "Microsoft",
                        Image = "http://launchedtoday.com/wp-content/uploads/2015/07/microsoft-logo-share.jpg",
                        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/96/Microsoft_logo_%282012%29.svg/512px-Microsoft_logo_%282012%29.svg.png"
                },
                new Company
                {
                    Key = CompanyKey.Oracle,
                        Name = "Oracle",
                        Image = "https://seeklogo.com/images/O/Oracle-logo-B4E100A83F-seeklogo.com.png",
                        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/50/Oracle_logo.svg/512px-Oracle_logo.svg.png"
                },
                new Company
                {
                    Key = CompanyKey.RSA,
                        Name = "RSA Security",
                        Image = "https://seeklogo.com/images/R/rsa-logo-BAE738ADB8-seeklogo.com.png",
                        Logo = "https://upload.wikimedia.org/wikipedia/en/thumb/2/2a/RSA_Security_logo2.svg/512px-RSA_Security_logo2.svg.png"
                },
                new Company
                {
                    Key = CompanyKey.SAP,
                        Name = "SAP",
                        Image = "https://seeklogo.com/images/S/sap-logo-60304662E6-seeklogo.com.png",
                        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/SAP_2011_logo.svg/512px-SAP_2011_logo.svg.png"
                },
                new Company
                {
                    Key = CompanyKey.Symantec,
                        Name = "Symantec",
                        Image = "https://awsmp-logos.s3.amazonaws.com/8329a4da-0eea-4695-994b-4f2d9866181f/3c5b5c129f104c32f6b2ae003f776245.png",
                        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Symantec_logo10.svg/512px-Symantec_logo10.svg.png"
                },
                new Company
                {
                    Key = CompanyKey.Toshiba,
                        Name = "Toshiba",
                        Image = "https://seeklogo.com/images/T/Toshiba-logo-EF732D6493-seeklogo.com.png",
                        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/01/Toshiba_logo.svg/512px-Toshiba_logo.svg.png"
                }
            };
        }
    }
}