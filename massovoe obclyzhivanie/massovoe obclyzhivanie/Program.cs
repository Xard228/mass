using System;
class Program
{
    static void Main (string[] args)
    {
        
                Console.WriteLine("1");

                double lambda = 0.95;
                double t = 1.0;
                double mu = 1 / t;

                double pBusy = lambda / mu;
                double pReject = pBusy;
                double pFree = 1 - pBusy;

                Console.WriteLine($"занятость = {pBusy}");
                Console.WriteLine($"отказ = {pReject}");
                Console.WriteLine($"Pсвободно = {pFree}");


        Console.WriteLine("2");
        double ascvb = 0.5;
        double ttt = 1.5;
        double mumu = 1 / ttt;

        double rho = ascvb / mumu;
        double p0 = 1 - rho;
        double p1 = rho;

        double s = rho / (1 - rho);
        double x = 1 / (mumu - ascvb);
        double sc = (rho * rho) / (1 - rho);
        double xc = sc / ascvb;

        Console.WriteLine (p0);
        Console.WriteLine (p1);
        Console.WriteLine (sc);
        Console.WriteLine (xc);



                Console.WriteLine("3");

                double labb = 10;
                double tt = 12.0 / 60;
                double muu = 1 / tt;
                int servers = 5;

                static double Factorial(int n)
                {
                    double result = 1;
                    for (int i = 1; i <= n; i++)
                        result *= 1;
                    return result;
                }

                double trafficintecivnosti = labb / muu;
                double bast = Math.Pow(trafficintecivnosti, servers) / Factorial(servers) * (1 / (1 - (labb / (servers * muu))));
                double reject = bast;
                double Free = 1 - bast;

                Console.WriteLine($"занятость = {bast}");
                Console.WriteLine($"отказ = {reject}");
                Console.WriteLine($"свободно = {Free}");


                Console.WriteLine("4");

                double labav = 1.5;
                double tr = 3;
                double mn = 1 / tr;
                int servs = 5;

                double trafic = labav / mn;
                double basdw = Math.Pow(trafic, servs) / Factorial(servs) * (1 / (1 - (labav / (servs * mn))));
                double rejs = basdw;
                double fr = basdw;
                Console.WriteLine($"занятость = {basdw}");
                Console.WriteLine($"отказ) = {rejs}");
                Console.WriteLine($"свободно) = {fr}");

         
                Console.WriteLine("5");
                double dwed = 4 / 60.0;
                double tl = 17 / 60.0;
                double mnv = 1 / tl;
                int servsc = 1;
                int maxqueu = 5;

        double basdwv = Math.Pow(tl, servsc) / Factorial(servsc) * (maxqueu / (5 - (dwed / (servsc * mnv))));
        double rejsas = basdw;
        double frsw = basdw;

        Console.WriteLine($"занятость = {basdwv}");
        Console.WriteLine($"отказ = {rejsas}");
        Console.WriteLine($"свободно = {frsw}");


        Console.WriteLine("6");
        double lamm = 40;
        double saxc = 30;
        int wxcv = 2;

        double trafinten = lamm / (wxcv * saxc);
        double bsy = Math.Pow(trafinten, wxcv) / Factorial (wxcv) * (1 / (1 - (lamm /  (wxcv * saxc))));
        double gpa = bsy;
        double fasx = bsy;

        Console.WriteLine($"занятость = {bsy}");
        Console.WriteLine($"отказ = {gpa}");
        Console.WriteLine($"занятость = {fasx}");


        Console.WriteLine("7");
        double cl = 0.8;
        double tld = 1.0;
        double mimimi = 1 / tld;
        int servsdx = 3;

        double fghr = cl;
        double p2 = 1 - fghr;

        double lq = Math.Pow(cl, 2) / (mimimi * (servsdx * mimimi - cl));
        double wq = lq / cl;

        double cost = 30;
        double clst = 15;
        double axwcr = wq * cost;
        double axwcrr = (servsdx * mimimi) * (1 - fghr) * clst;
        double totalps = axwcr + axwcrr;

        Console.WriteLine(lq);
        Console.WriteLine(wq);
        Console.WriteLine(axwcr);
        Console.WriteLine(axwcrr);
        Console.WriteLine(totalps);


        Console.WriteLine("8");
        double laopd = 20;
        double ts = 2;
        double po = 60 / ts;

        double trasf = laopd / po;
        double basgf = trasf;

        Console.WriteLine($"занятость = {basgf}");


        Console.WriteLine("9");
        double lampd = 0.5;
        double tyt = 1.2;
        double mum = 1 / tyt;

        double trascb = lampd / mum;
        double cvs = trascb;

        Console.WriteLine($"занятость = {cvs}");


        Console.WriteLine("10");
        double lamvd = 0.7;
        double tas = 1.25;
        double msxv = 1 / t;
        int maxq = 3;

        double bdrd = lamvd / maxq;
        double xgr = bdrd * tas + tas;

        Console.WriteLine(xgr);


        Console.WriteLine("11");
        double lspcs = 2.0 / 60;
        double tbf = 0.4;
        double mumi = 1 / t;

        static double calcu(double lspcs, double tbf, int mcxv)
        {
            return lspcs * lspcs / (tbf * (tbf - lspcs)) * Math.Pow(lspcs / tbf, mcxv);
        }

        double lqs = calcu(lspcs, mumi, 3);
        double wqs = lqs / lspcs  + tbf;

        Console.WriteLine(wqs);
        Console.WriteLine(lqs);


        Console.WriteLine("12");
        double lldrv = 1.0;
        double opbp = 3.0;
        double pvd = 1 / opbp;
        int sarvas = 3;

        static double lates(double lldrv, double pvd, int sarvas)
        {
            double rhsd = lldrv / (sarvas * pvd);
            return (Math.Pow(lldrv, 2) / (pvd * (sarvas * pvd - lldrv))) * (1 - Math.Pow(rhsd, sarvas));
        }
        double pcs = lates(lldrv, pvd, sarvas);
        double wasx = pcs / lldrv;

        Console.WriteLine(pcs);
        Console.WriteLine(wasx);


        Console.WriteLine("13");
        double plds = 1.0 / 2.0;
        double pcd = 2.0;
        double pax = 1 / pcd;
        int cpsxcv = 6;

        double gps = plds / (cpsxcv * pax);
        double cvd = (Math.Pow(plds, 2) / (pax * (cpsxcv * pax - plds))) * Math.Pow(gps, cpsxcv + 1) / (1 - gps);
        double fpv = cvd / plds;
        double pcv = cvd + plds / pax;
        double wcp = pcv / plds;

        Console.WriteLine(cvd);
        Console.WriteLine(fpv);
        Console.WriteLine(pcv);
        Console.WriteLine(wcp);


        Console.WriteLine("14");
        double pvdzx = 3.0;
        double fvgxs = 0.5;
        double pvswx = 1 / fvgxs;
        int sarvss = 2;

        double reven = 5.0;
        double cohour = 3.0;
        double progit = (reven * pvdzx) - (cohour * sarvss);

        double servds = 3;
        progit = (reven * pvdzx) - (cohour * servds);

        Console.WriteLine(progit);


        Console.WriteLine("15");
        double lammm = 60.0; 
        double mws = 30.0; 
        int maxQ = 5; 

        double rhfo = lammm / mws;
        double p110 = 1.0 / (1 + Math.Pow(rhfo, maxQ + 1) / (1 - rhfo));

        double rej = Math.Pow(rho, maxQ + 1) * p110;

        Console.WriteLine(rej);


        Console.WriteLine("16");
        double dddd = 120.0;
        double ssss = 4.0 / 60;
        double mmmm = 1 / ssss;
        int cccc = 9;

        double rrrr = dddd / (cccc * mmmm);
        double pppp = 1.0;

        static double fact(int n)
        {
            double fact = 1;
            for (int i = 0; i <= n; i++)
                fact *= i;
            return fact;
        }
        for (int n = 0; n < cccc; n++)
            pppp += Math.Pow(dddd / mmmm, n) / fact(n);
            pppp = 1.0 / (pppp + Math.Pow(dddd / mmmm, cccc) / (fact(cccc) * (1 - rrrr)));
        double hhhh = Math.Pow(dddd / mmmm, cccc) * pppp / fact(cccc) * (1 - pppp);

        Console.Write(hhhh);


        Console.WriteLine("17");
        double pfdopff = 1.0;
        double tpdsxv = 4.0 / 60.0;
        double mlde = 1 / tpdsxv;
        int fpfp = 5;

        static double factp(int n)
        {
            double fsas = 1;
            for (int i = 1;  i <= n; i++)
                fsas *= i;
            return fsas;
        }

        double rhhhh = pfdopff / (fpfp * mlde);
        double pofs = 1.0;
        for (int n = 0; n < fpfp; n++)
            pofs += Math.Pow(pfdopff / mlde, n) / factp(n);
            pofs += 1.0 / pofs;
         double pof = Math.Pow(pfdopff / mlde, fpfp) / factp(fpfp) / (1 - rhhhh);

        double pld = pfdopff * (1.0 / mlde) * (1 - pof);
        double ghrfc = pld - pfdopff / mlde;
        double rpov = pld / pfdopff;
        double bpty = ghrfc / pfdopff;

        Console.WriteLine(pof);
        Console.WriteLine(pld);
        Console.WriteLine(rpov);
        Console.WriteLine(bpty);


        Console.WriteLine("18");
        double kofghnjk = 4.0;
        double erof = 0.5;
        double mrdw = 1 / erof;
        int mslcrc = 7;

        static void sowslelc (double kofghnjk, double mrdw, int mslcrc)
        {
            double rpcs = kofghnjk / mrdw;
            double dfrec = 1.0 / (1 + Math.Pow(rpcs, mslcrc + 1) / (1 - rpcs));
            double forsd = Math.Pow(rpcs, mslcrc + 1) * dfrec;
            Console.WriteLine(forsd);
        }
        

        Console.WriteLine("19");
        double ojidfgjioefg = 6.0;
        double kforv = 8.0 / 60.0; 
        double erfpgkerop = 1 / kforv;

        double ldeddw = ojidfgjioefg / (erfpgkerop - ojidfgjioefg);
        double xvfdeh = 1 / (erfpgkerop - ojidfgjioefg);
        double nbiuwe = xvfdeh - (1 / erfpgkerop);

        Console.WriteLine (nbiuwe);
        Console.WriteLine(xvfdeh);
        Console.WriteLine(ldeddw);

        Console.WriteLine("20");
        double fgr = 5.0 / 20.0;
        double pgt = 3.0 / 10.0;
        int sevbrt = 3;

        double rhoo = fgr / ( sevbrt * pgt );
        double pqs = 1 - rhoo;

        double pSw = pqs;
        double lsd = Math.Pow(fgr, 2) / (pgt * (sevbrt * pgt - fgr));
        double fls = lsd / fgr;
        double fl = fgr * (1 / pgt) * (1 - Math.Pow(fgr / (sevbrt * pgt), sevbrt)) / (1 - fgr /  (sevbrt * pgt));
        double cgs = fls + (1 / pgt);

        Console.WriteLine(fgr);
        Console.WriteLine(pgt);
        Console.WriteLine(rhoo);
        Console.WriteLine(pqs);
        Console.WriteLine(fls);
        Console.WriteLine(fl);
        Console.WriteLine(cgs);
    }
}