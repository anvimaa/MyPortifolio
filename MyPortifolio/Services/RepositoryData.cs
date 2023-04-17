using MyPortifolio.Data;

namespace MyPortifolio.Services
{
    public static class RepositoryData
    {
        public static PersonalInfo PersonalInfo = new PersonalInfo(
            "Antonio",
            "Mantente",
            "Developer FullStack",
            "Estudante Univeritário, amante de Tecnoligias, Mercado de Forex e Criptomoedas",
            "António Vinda Mantente, solteiro de 23 anos de idade, estudante de Engenharia Informática pelo IP da Unikiv. Amanante de técnologias,...");

        public static List<AboutItemData> AboutItems = new List<AboutItemData>
        {
            new AboutItemData("+5","Anos de","Experiência"),
            new AboutItemData("+10","Projetcos","Feitos"),
            new AboutItemData("+1000","Likes nas","Redes Sociais")
        };

        public static List<ProgressBarData> ProgressBars = new List<ProgressBarData>
        {
            new ProgressBarData("C#","80%"),
            new ProgressBarData("ASP.NET Core","70%"),
            new ProgressBarData("HTML5","95%"),
            new ProgressBarData("CSS3","95%"),
            new ProgressBarData("JavaScript","95%"),
            new ProgressBarData("Python","80%"),
            new ProgressBarData("VB.NET","75%"),
        };

        public static List<TimeLineItemData> TimeLineItems = new List<TimeLineItemData>
        {
            new TimeLineItemData(
                "2013-2015",
                "Ensino Secundário",
                "Colégio 11 de Novembro",
                "Fiz o ensino secundário durante esse periodo no Colégio 11 de Novembro",
                "fas fa-briefcase"),
            new TimeLineItemData(
                "2016-2019",
                "Ensino Médio",
                "Instituto Médio de Administração e Gestão do Uíge",
                "Fiz o ensino médio durante esse periodo no IMAG Uíge, saindo no quadro de Honra como o único com a nota mais alta naquela instituição numa defesa do fim do curso (20 valores).",
                "fas fa-briefcase"),
            new TimeLineItemData(
                "Junho de 2019 á Agosto de 2019",
                "Estágio Curricular",
                "Gabinete Provincial da Cultura, Turismo e Desporto do Uíge",
                "Fiz um estágio curricular durante esse periodo no GPCTD, na áre de Recursos Humanos e Finanças).",
                "fas fa-briefcase")
        };

        public static List<PortifolioItemData> PortifolioItems = new List<PortifolioItemData>
        {
            new PortifolioItemData("img/port1.jpg","#",string.Empty),
            new PortifolioItemData("img/port2.jpg","#",string.Empty),
            new PortifolioItemData("img/port3.jpg","#","#"),
            new PortifolioItemData("img/port4.jpg","#",string.Empty),
            new PortifolioItemData("img/port5.jpg","#","#"),
            new PortifolioItemData("img/port6.jpg","#","#"),
            new PortifolioItemData("img/port7.jpg","#",string.Empty),
        };

        public static List<CertificacaoItemData> CertificacaoItems = new List<CertificacaoItemData>
        {
            new CertificacaoItemData(
                "Ensino Médio",
                "/img/blog1.jpg",
                "Certficado do ensino médio"),
            new CertificacaoItemData(
                "Informática Básica",
                "/img/blog2.jpg",
                "Certficado do informática"),
            new CertificacaoItemData(
                "Eletrecidade",
                "/img/blog3.jpg",
                "Certficado de eletrecidade"),
            new CertificacaoItemData(
                "Certificado de Participação",
                "/img/blog3.jpg",
                "Certificado de participação na feira do inventor do Uige 2019"),
        };
    }
}
