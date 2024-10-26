﻿using System.Net.Http;

string[] data = ["4U8AGBFEWHBO", "4U9MX38QP2NL", "4UA5HBVRP21Q", "4UAFHXLN7SSD", "4UALFUOG5EVC", "4UASWLLDOAPV", "4UAVGDTCKY1G", "4UAX42U8LJMM", "4UB7GQIBXSN5", "4UBKUHFWYCGW", "4UBPKOPHCKOP", "4UBRUTTHX3ZU", "4UC2QUNRRKAH", "4UCHHHKR2I3M", "4UCQKIWMAWJO", "4UCTWQEYFNXR", "4UCXS1OUJJ2S", "4UD3APL01V5X", "4UD7TPCWN2Q6", "4UDHRDHGYULN", "4UDUKTVH1BAG", "4UE0HP7A0NSC", "4UEC1CLRJMWQ", "4UF71NSYT0RI", "4UFBFBSPSXLY", "4UFUZNWOFOP7", "4UFZWBWMYQEY", "4UGQN8ZFJ6KE", "4UGQOVDLJCZL", "4UGWSVODVMEJ", "4UGZRNSKNJSO", "4UHA9LYR10AT", "4UHAXBQ8NHBF", "4UHNONCW9EXH", "4UHRNUXWPHZR", "4UID7HTB7VCY", "4UIEGKOKXJSP", "4UIOUMQMCUOB", "4UJH4NVLCBKS", "4UJI1ELK5MWW", "4UJQVXDQBREX", "4UJRL6OUMJQI", "4UJWGHMLFFGW", "4UJWVQPFUQYX", "4ULMQ6AMKYYL", "4UMCQYGRJUY0", "4UMJEU94IIPY", "4UMKZ3NQ5GZW", "4UN5XPHEHW9B", "4UNCNBIBXQEX", "4UNQWCIITGEY", "4UNTLP7I2N9V", "4UNYJ0SRUXVA", "4UOAFSZUH2YG", "4UOWBCTQYFAJ", "4UOZ0EHIONBN", "4UPHRFYXFJMY", "4UQ4HPXCILEL", "4UQ56BWQNGCL", "4UQAWGBDFBBM", "4UQBCRXBTQ8U", "4UQEBZ9NX2Y4", "4UQJ6OW1VV3T", "4UR196GQ6RJW", "4URGF29WBW2I", "4URMWIWBLAE1", "4URUUPLO9P2Q", "4URW6K6OTVVS", "4USVVDDCBYMO", "4UT7HBZIDFNZ", "4UTCUEOTZCSV", "4UUANNTDSLFO", "4UUCGZT7MHGN", "4UUH50QNL77K", "4UUS11UAQ0XZ", "4UUTKVEUZ7DC", "4UX2EREZENYJ", "4UXSMLEGJOJJ", "4UXVSK3CLAGO", "4UYPYCWCB7TP", "4UZC3L9SSWXA", "4UZTT0OLNRP6", "4UZV6GUXD7IP", "4UZW6WEPH776", "4V12QJS5PY8D", "4V1CJGPQMMTE", "4V1VLV9SGBR1", "4V2DNAJMALDK", "4V2I9DU1QMH8", "4V2LXRI7YJW1", "4V2PXA6N8PLT", "4V2TP8JTVDAD", "4V2YKL1B3U95", "4V3BROPG89DX", "4V3PAXFERBVI", "4V63DL0XVFW5", "4V7Y8ZC9WRSJ", "4V81KZKHLVKN", "4V90NOHYHGLG", "4VAAYTBAZUFD", "4VAH91MRIV7T", "4VALHWWYPWRD", "4VAP57UEMN3M", "4VAPWBNGEHNO", "4VBPTY2YSXWN", "4VBVCA3B9JCC", "4VBVL1DO9DGG", "4VBZ0OZETAER", "4VC9WNDIUZMH", "4VCICMGFUKRD", "4VCPEZJD5AXS", "4VCQSTMOY4GH", "4VCWNPXQOOWB", "4VD2A1ACOEJY", "4VDKFQRQNVD4", "4VDOJPGBHPHY", "4VDX2HBAEJG1", "4VDXJMNPHZIM", "4VE5YYUSYVKV", "4VEAFAV8RBZE", "4VFFSICGJMNJ", "4VFMVAOBBBSP", "4VFROLIU8RTG", "4VFRQB11XUVQ", "4VG95R1UYITV", "4VGACH2B223S", "4VGHXXKFGACI", "4VGHY3QEOQRJ", "4VGNMOJBGYM4", "4VGYM9ZAPHNH", "4VGYPNHCKGRO", "4VHNY0UJSUQP", "4VIC09ACQ6KC", "4VIPSEWLN8LI", "4VJAP5NPJ2QE", "4VJRHLTRXOPC", "4VJVIP4LIOQS", "4VKC5HDL0RNJ", "4VKD392RDX4X", "4VKQUCOGYYTS", "4VKSMISR8Y2N", "4VKYBVH0KYUE", "4VL4WRQGTF5G", "4VL8XIMEIZME", "4VLAGWDQTNHQ", "4VLGVXNAZZRO", "4VLTV2AHPVRR", "4VMCYHSSOMZH", "4VMJFCTJJ1CT", "4VMVI68SB8HG", "4VNAADMCUL0G", "4VNZCOZVYXXN", "4VO3YDUVKVTV", "4VODWDAY2AEZ", "4VOLI4ACX117", "4VORB7HR9Y38", "4VOW0BSVKZJE", "4VP4QFBZZ5AP", "4VPFXNXHZ86X", "4VPOMK4Y3NPS", "4VQ663IACI3C", "4VQB4V9YWBL0", "4VRP0ZYLZXHM", "4VRSGUTEH4V1", "4VRUVFDBAEGW", "4VSD8RWC01OY", "4VSJGQWI4QIP", "4VSJTOETFQQ0", "4VSNMYUT9JQS", "4VT9KPUN0V9X", "4VTGUO35WDLD", "4VTJ3ZYG6H3F", "4VTTKTZP7MJ3", "4VTWVZMGHKEB", "4VTY2XSUA9V5"];

var httpClient = new HttpClient();
foreach (var item in data)
{
    var couponCode = item.Trim();
    var url = $"https://coupon.netmarble.com/api/coupon/reward?gameCode=sololv&couponCode={couponCode}&langCd=EN_US&pid=6056E4C440A34C64A2B7CAE0839DFB49";

    try
    {
        var response = await httpClient.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Response for coupon '{couponCode}': {result}");
        }
        else
        {
            Console.WriteLine($"Failed to retrieve data for coupon '{couponCode}'. Status Code: {response.StatusCode}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error fetching data for coupon '{couponCode}': {ex.Message}");
    }
}