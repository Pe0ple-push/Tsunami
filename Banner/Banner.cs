namespace TsunamiApp
{
    public class Banner
    {
        public static void BannerLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"                                                                                                                                                                                                                                                                                       
                                         -+               
                                           +--   
                                            +- +--++++++     
        -- +-                                --+             
        - ++-.                              -++              
        -.   ++-..  +                      .-++              
         --    +++++-- ..              ....--++              
           -.   . . +++.+.++-   .-----------+++              
            +   .  .   +-+--++-.-----+++++++++               
              +. ..   -  ++ .+-++-+--+-++++++       Tsunami <Version V.zero>
                -- .+ - .++..-+#+ +.---++++              Console Prototype    
                    +--+.-+- .+-+.++-++++                    
                    +++   . +-- +++++-                       
                    +++      +---                            
                    +++         +- .                         
                     ++          - -.-                       
                                     ++                                                                                                                                    
               ");
            Console.ResetColor();
        }
    }

}