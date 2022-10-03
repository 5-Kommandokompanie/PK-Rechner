﻿using System.Collections.ObjectModel;

namespace PK_Rechner_MAUI;

public static class Helper
{
    public static ObservableCollection<Nachname> InitializeChars(ObservableCollection<Nachname> nachnamen)
    {
        nachnamen.Add(new Nachname('A', 12));
        nachnamen.Add(new Nachname('B', 14));
        nachnamen.Add(new Nachname('C', 16));
        nachnamen.Add(new Nachname('D', 18));
        nachnamen.Add(new Nachname('E', 20));
        nachnamen.Add(new Nachname('F', 22));
        nachnamen.Add(new Nachname('G', 24));
        nachnamen.Add(new Nachname('H', 26));
        nachnamen.Add(new Nachname('I', 28));
        nachnamen.Add(new Nachname('J', 06));
        nachnamen.Add(new Nachname('K', 08));
        nachnamen.Add(new Nachname('L', 10));
        nachnamen.Add(new Nachname('M', 12));
        nachnamen.Add(new Nachname('N', 14));
        nachnamen.Add(new Nachname('O', 16));
        nachnamen.Add(new Nachname('P', 18));
        nachnamen.Add(new Nachname('Q', 20));
        nachnamen.Add(new Nachname('R', 22));
        nachnamen.Add(new Nachname('S', 04));
        nachnamen.Add(new Nachname('T', 06));
        nachnamen.Add(new Nachname('U', 08));
        nachnamen.Add(new Nachname('V', 10));
        nachnamen.Add(new Nachname('W', 12));
        nachnamen.Add(new Nachname('X', 14));
        nachnamen.Add(new Nachname('Y', 16));
        nachnamen.Add(new Nachname('Z', 18));

        return nachnamen;
    }

    public static ObservableCollection<KWEA> InitializeKWEAs(ObservableCollection<KWEA> kweas)
    {
        kweas.Add(new KWEA(101, "Hamburg"));
        kweas.Add(new KWEA(105, "Itzehoe"));
        kweas.Add(new KWEA(106, "Kiel"));
        kweas.Add(new KWEA(107, "Lübeck"));
        kweas.Add(new KWEA(108, "Bad Oldesloe"));
        kweas.Add(new KWEA(112, "Schleswig"));
        kweas.Add(new KWEA(114, "Heide"));
        kweas.Add(new KWEA(201, "Aurich"));
        kweas.Add(new KWEA(202, "Braunschweig"));
        kweas.Add(new KWEA(203, "Bremen"));
        kweas.Add(new KWEA(205, "Celle"));
        kweas.Add(new KWEA(206, "Hameln"));
        kweas.Add(new KWEA(207, "Hannover"));
        kweas.Add(new KWEA(208, "Hildesheim"));
        kweas.Add(new KWEA(209, "Lüneburg"));
        kweas.Add(new KWEA(210, "Meppen"));
        kweas.Add(new KWEA(211, "Nienburg"));
        kweas.Add(new KWEA(212, "Göttingen"));
        kweas.Add(new KWEA(213, "Oldenburg"));
        kweas.Add(new KWEA(214, "Osnabrück"));
        kweas.Add(new KWEA(215, "Stade"));
        kweas.Add(new KWEA(216, "Goslar"));
        kweas.Add(new KWEA(301, "Aachen"));
        kweas.Add(new KWEA(302, "Arnsberg"));
        kweas.Add(new KWEA(303, "Bielefeld"));
        kweas.Add(new KWEA(304, "Bochum"));
        kweas.Add(new KWEA(305, "Bonn"));
        kweas.Add(new KWEA(306, "Coesfeld"));
        kweas.Add(new KWEA(307, "Detmold"));
        kweas.Add(new KWEA(308, "Dortmund"));
        kweas.Add(new KWEA(309, "Duisburg"));
        kweas.Add(new KWEA(310, "Düsseldorf"));
        kweas.Add(new KWEA(311, "Essen"));
        kweas.Add(new KWEA(312, "Bergisch Gladbach"));
        kweas.Add(new KWEA(313, "Gelsenkirchen"));
        kweas.Add(new KWEA(314, "Hagen"));
        kweas.Add(new KWEA(315, "Herford"));
        kweas.Add(new KWEA(316, "Jülich"));
        kweas.Add(new KWEA(318, "Köln"));
        kweas.Add(new KWEA(320, "Krefeld"));
        kweas.Add(new KWEA(321, "Mettmann"));
        kweas.Add(new KWEA(322, "Mönchengladbach"));
        kweas.Add(new KWEA(323, "Münster"));
        kweas.Add(new KWEA(324, "Recklinghausen"));
        kweas.Add(new KWEA(325, "Schwelm"));
        kweas.Add(new KWEA(326, "Siegen"));
        kweas.Add(new KWEA(327, "Solingen"));
        kweas.Add(new KWEA(328, "Unna"));
        kweas.Add(new KWEA(329, "Wesel"));
        kweas.Add(new KWEA(330, "Wuppertal"));
        kweas.Add(new KWEA(401, "Darmstadt"));
        kweas.Add(new KWEA(402, "Frankfurt am Main"));
        kweas.Add(new KWEA(403, "Fulda"));
        kweas.Add(new KWEA(406, "Heppenheim"));
        kweas.Add(new KWEA(407, "Kaiserslautern"));
        kweas.Add(new KWEA(408, "Kassel"));
        kweas.Add(new KWEA(409, "Koblenz"));
        kweas.Add(new KWEA(410, "Bad Kreuznach"));
        kweas.Add(new KWEA(411, "Mainz"));
        kweas.Add(new KWEA(412, "Gelnhausen"));
        kweas.Add(new KWEA(412, "Marburg"));
        kweas.Add(new KWEA(413, "Neuwied"));
        kweas.Add(new KWEA(414, "Neustadt/Weinstraße"));
        kweas.Add(new KWEA(415, "Trier"));
        kweas.Add(new KWEA(416, "Wetzlar"));
        kweas.Add(new KWEA(417, "Wiesbaden"));
        kweas.Add(new KWEA(423, "Saarbrücken"));
        kweas.Add(new KWEA(424, "Saarlouis"));
        kweas.Add(new KWEA(425, "Sankt Wendel"));
        kweas.Add(new KWEA(501, "Schwäbisch Gmünd"));
        kweas.Add(new KWEA(502, "Donaueschingen"));
        kweas.Add(new KWEA(503, "Freiburg"));
        kweas.Add(new KWEA(505, "Karlsruhe"));
        kweas.Add(new KWEA(507, "Ludwigsburg"));
        kweas.Add(new KWEA(508, "Mannheim"));
        kweas.Add(new KWEA(509, "Offenburg"));
        kweas.Add(new KWEA(510, "Ravensburg"));
        kweas.Add(new KWEA(512, "Heilbronn"));
        kweas.Add(new KWEA(513, "Stuttgart"));
        kweas.Add(new KWEA(514, "Tübingen"));
        kweas.Add(new KWEA(515, "Ulm"));
        kweas.Add(new KWEA(521, "Lörrach"));
        kweas.Add(new KWEA(601, "Ansbach"));
        kweas.Add(new KWEA(602, "Aschaffenburg"));
        kweas.Add(new KWEA(603, "Augsburg"));
        kweas.Add(new KWEA(604, "Bamberg"));
        kweas.Add(new KWEA(605, "Deggendorf"));
        kweas.Add(new KWEA(609, "Bayreuth"));
        kweas.Add(new KWEA(611, "Kempten"));
        kweas.Add(new KWEA(612, "München"));
        kweas.Add(new KWEA(615, "Nürnberg"));
        kweas.Add(new KWEA(616, "Regensburg"));
        kweas.Add(new KWEA(617, "Traunstein"));
        kweas.Add(new KWEA(618, "Weiden"));
        kweas.Add(new KWEA(619, "Würzburg"));
        kweas.Add(new KWEA(622, "Weilheim"));
        kweas.Add(new KWEA(629, "Ingolstadt"));
        kweas.Add(new KWEA(701, "Aschersleben"));
        kweas.Add(new KWEA(702, "Bautzen"));
        kweas.Add(new KWEA(703, "Chemnitz"));
        kweas.Add(new KWEA(704, "Cottbus"));
        kweas.Add(new KWEA(704, "Wittenberg"));
        kweas.Add(new KWEA(705, "Dresden"));
        kweas.Add(new KWEA(706, "Eberswalde"));
        kweas.Add(new KWEA(707, "Erfurt"));
        kweas.Add(new KWEA(708, "Frankfurt/Oder"));
        kweas.Add(new KWEA(709, "Gera"));
        kweas.Add(new KWEA(710, "Halle"));
        kweas.Add(new KWEA(711, "Jena"));
        kweas.Add(new KWEA(712, "Leipzig"));
        kweas.Add(new KWEA(713, "Magdeburg"));
        kweas.Add(new KWEA(714, "Mühlhausen"));
        kweas.Add(new KWEA(715, "Neubrandenburg"));
        kweas.Add(new KWEA(716, "Neuruppin"));
        kweas.Add(new KWEA(717, "Potsdam"));
        kweas.Add(new KWEA(718, "Rostock"));
        kweas.Add(new KWEA(719, "Schwerin"));
        kweas.Add(new KWEA(720, "Stendal"));
        kweas.Add(new KWEA(721, "Strahlsund"));
        kweas.Add(new KWEA(722, "Suhl"));
        kweas.Add(new KWEA(723, "Wittenberg"));
        kweas.Add(new KWEA(724, "Zwickau"));
        kweas.Add(new KWEA(725, "Berlin"));
        kweas.Add(new KWEA(726, "Berlin"));

        return kweas;
    }

    public static ObservableCollection<int> InitializeLfd(ObservableCollection<int> lfd)
    {
        for (int i = 1; i < 10; i++)
        {
            lfd.Add(i);
        }

        return lfd;
    }
}
