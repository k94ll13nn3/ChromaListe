function randomizePost()
{var postsUrl=["/ChromaListe/posts/2013-10-13-seracrawl","/ChromaListe/posts/2014-07-26-ptitard","/ChromaListe/posts/2013-10-27-relicanth","/ChromaListe/posts/2014-08-03-remoraid","/ChromaListe/posts/2014-02-07-insolourdo","/ChromaListe/posts/2014-08-06-nodulithe","/ChromaListe/posts/2014-02-09-m-mime","/ChromaListe/posts/2014-08-12-goelise","/ChromaListe/posts/2014-02-21-magicarpe","/ChromaListe/posts/2014-08-12-metang","/ChromaListe/posts/2014-03-02-lumivole","/ChromaListe/posts/2014-09-06-luxio","/ChromaListe/posts/2014-03-07-exagide","/ChromaListe/posts/2014-09-15-camerupt","/ChromaListe/posts/2014-03-22-scorplane","/ChromaListe/posts/2014-10-18-wattouat","/ChromaListe/posts/2014-04-19-scorvol","/ChromaListe/posts/2014-12-28-mangriff","/ChromaListe/posts/2014-04-21-pitrouille","/ChromaListe/posts/2014-12-30-regirock","/ChromaListe/posts/2014-05-07-banshitrouye","/ChromaListe/posts/2015-01-19-kyurem","/ChromaListe/posts/2014-07-03-evoli","/ChromaListe/posts/2015-01-20-miamiasme","/ChromaListe/posts/2014-08-02-mamanbo","/ChromaListe/posts/2015-03-24-nosferapti","/ChromaListe/posts/2014-08-03-loupio","/ChromaListe/posts/2015-03-27-phogleur","/ChromaListe/posts/2014-08-05-mime-jr-2","/ChromaListe/posts/2015-03-30-wailmer","/ChromaListe/posts/2014-08-05-mime-jr","/ChromaListe/posts/2015-04-01-poissirene","/ChromaListe/posts/2014-08-17-doudouvet","/ChromaListe/posts/2015-04-18-raikou","/ChromaListe/posts/2014-08-29-farfaduvet","/ChromaListe/posts/2015-04-24-roselia","/ChromaListe/posts/2014-09-07-limonde","/ChromaListe/posts/2015-05-01-kaimorse","/ChromaListe/posts/2014-09-07-pachirisu","/ChromaListe/posts/2015-05-17-cochignon","/ChromaListe/posts/2014-10-23-chuchmur","/ChromaListe/posts/2015-05-20-goupix","/ChromaListe/posts/2014-12-16-ecrapince","/ChromaListe/posts/2015-05-23-meditikka","/ChromaListe/posts/2015-01-28-latias","/ChromaListe/posts/2015-06-18-nosferalto","/ChromaListe/posts/2015-02-09-seviper","/ChromaListe/posts/2015-06-20-mysdibule","/ChromaListe/posts/2015-02-20-barpau","/ChromaListe/posts/2015-06-20-nostenfer","/ChromaListe/posts/2015-02-24-milobellus","/ChromaListe/posts/2015-06-21-galegon","/ChromaListe/posts/2015-03-22-cresselia","/ChromaListe/posts/2015-07-02-zarbi","/ChromaListe/posts/2015-03-22-obalie","/ChromaListe/posts/2015-07-07-tetarte","/ChromaListe/posts/2015-04-01-poissoroy","/ChromaListe/posts/2015-09-30-zekrom","/ChromaListe/posts/2015-04-02-leviator","/ChromaListe/posts/2015-10-06-stalgamin","/ChromaListe/posts/2015-04-03-sharpedo","/ChromaListe/posts/2015-10-07-mammochon","/ChromaListe/posts/2015-04-04-sorbebe","/ChromaListe/posts/2015-10-11-grelacon","/ChromaListe/posts/2015-06-12-grainipiot","/ChromaListe/posts/2016-02-26-hypotrempe","/ChromaListe/posts/2015-06-15-zigzaton","/ChromaListe/posts/2016-03-08-regice","/ChromaListe/posts/2015-06-17-lineon","/ChromaListe/posts/2016-03-11-mesmerella","/ChromaListe/posts/2015-06-18-galekid","/ChromaListe/posts/2016-03-11-scrutella","/ChromaListe/posts/2015-07-08-tartard","/ChromaListe/posts/2016-04-19-gamblast","/ChromaListe/posts/2015-07-10-tarpaud","/ChromaListe/posts/2016-04-21-regigigas","/ChromaListe/posts/2015-08-10-mystherbe","/ChromaListe/posts/2016-06-06-rafflesia","/ChromaListe/posts/2015-08-21-doduo","/ChromaListe/posts/2016-07-18-joliflor","/ChromaListe/posts/2015-10-14-stari","/ChromaListe/posts/2016-08-14-colimucus","/ChromaListe/posts/2015-10-14-tarinor","/ChromaListe/posts/2016-08-14-sonistrelle","/ChromaListe/posts/2015-10-16-ortide","/ChromaListe/posts/2016-08-20-muplodocus","/ChromaListe/posts/2016-02-20-kranidos","/ChromaListe/posts/2016-08-26-lokhlass","/ChromaListe/posts/2016-03-12-queulorior","/ChromaListe/posts/2016-12-16-brindibou","/ChromaListe/posts/2016-03-13-zigzaton","/ChromaListe/posts/2016-12-17-plumeline","/ChromaListe/posts/2016-03-21-registeel","/ChromaListe/posts/2016-12-19-vorasterie","/ChromaListe/posts/2016-03-23-hypocean","/ChromaListe/posts/2016-12-22-picassaut","/ChromaListe/posts/2016-03-26-voltorbe","/ChromaListe/posts/2017-02-11-passerouge","/ChromaListe/posts/2016-03-27-electrode","/ChromaListe/posts/2017-02-15-spectrum","/ChromaListe/posts/2016-04-07-frison","/ChromaListe/posts/2017-02-17-ectoplasma","/ChromaListe/posts/2016-04-14-flingouste","/ChromaListe/posts/2017-02-19-terhal","/ChromaListe/posts/2016-10-08-entei","/ChromaListe/posts/2017-02-23-nidoran","/ChromaListe/posts/2016-11-22-geolithe","/ChromaListe/posts/2017-03-04-rocabot","/ChromaListe/posts/2016-12-07-rapasdepic","/ChromaListe/posts/2017-03-08-rattata-alola","/ChromaListe/posts/2016-12-11-bacabouh","/ChromaListe/posts/2017-03-11-tadmorv-alola","/ChromaListe/posts/2017-01-11-nymphali","/ChromaListe/posts/2017-05-22-tylton","/ChromaListe/posts/2017-01-21-caninos","/ChromaListe/posts/2017-05-30-noeunoeuf","/ChromaListe/posts/2017-01-26-nosferapti","/ChromaListe/posts/2017-06-05-suicune","/ChromaListe/posts/2017-01-31-manglouton","/ChromaListe/posts/2017-09-02-altaria","/ChromaListe/posts/2017-02-03-pichu","/ChromaListe/posts/2017-09-08-crabagarre","/ChromaListe/posts/2017-02-03-pikachu","/ChromaListe/posts/2017-09-10-baudrive","/ChromaListe/posts/2017-02-04-metamorph","/ChromaListe/posts/2017-09-12-mimigal","/ChromaListe/posts/2017-02-05-reshiram","/ChromaListe/posts/2017-09-12-ramoloss","/ChromaListe/posts/2017-03-14-feuforeve","/ChromaListe/posts/2017-10-09-germignon","/ChromaListe/posts/2017-03-26-sabelette-alola","/ChromaListe/posts/2017-10-17-crocrodil","/ChromaListe/posts/2017-04-01-araqua","/ChromaListe/posts/2017-10-19-racaillou","/ChromaListe/posts/2017-04-16-tarenbulle","/ChromaListe/posts/2017-10-22-miaouss-alola","/ChromaListe/posts/2017-04-28-kaiminus","/ChromaListe/posts/2017-10-24-chamallot","/ChromaListe/posts/2017-05-07-tiboudet","/ChromaListe/posts/2017-10-28-gravalanch","/ChromaListe/posts/2017-05-21-minidraco","/ChromaListe/posts/2017-10-28-grolem","/ChromaListe/posts/2017-05-21-nenupiot","/ChromaListe/posts/2017-10-28-tarinorme","/ChromaListe/posts/2017-09-22-amagara","/ChromaListe/posts/2017-11-26-pierroteknik","/ChromaListe/posts/2017-09-25-cadoizo","/ChromaListe/posts/2017-11-28-xerneas","/ChromaListe/posts/2017-09-25-moufflair","/ChromaListe/posts/2017-11-30-zorua","/ChromaListe/posts/2017-09-25-moufouette","/ChromaListe/posts/2017-12-03-engloutyran","/ChromaListe/posts/2017-09-28-lovdisc","/ChromaListe/posts/2017-12-14-ho-oh","/ChromaListe/posts/2017-09-29-spoink","/ChromaListe/posts/2017-12-17-scalpion","/ChromaListe/posts/2017-09-30-groret","/ChromaListe/posts/2018-01-07-katagami","/ChromaListe/posts/2017-09-30-magneti","/ChromaListe/posts/2018-02-13-celebi","/ChromaListe/posts/2017-10-28-yanma","/ChromaListe/posts/2017-10-29-drascore","/ChromaListe/posts/2017-10-29-goinfrex","/ChromaListe/posts/2017-10-29-manzai","/ChromaListe/posts/2017-10-29-rapion","/ChromaListe/posts/2017-10-31-polichombr","/ChromaListe/posts/2017-11-05-kraknoix","/ChromaListe/posts/2017-11-21-arkeapti","/ChromaListe/posts/2018-12-03-groudon","/ChromaListe/posts/2018-12-05-tritox","/ChromaListe/posts/2019-12-14-charbi","/ChromaListe/posts/2019-12-21-sinistrail","/ChromaListe/posts/2020-01-04-nigosier"];var postsTitle=["Séracrawl","Ptitard","Relicanth","Rémoraid","Insolourdo","Nodulithe","M. Mime","Goélise","Magicarpe","Métang","Lumivole","Luxio","Exagide","Camérupt","Scorplane","Wattouat","Scorvol","Mangriff","Pitrouille","Regirock","Banshitrouye","Kyurem","Évoli","Miamiasme","Mamanbo","Nosferapti","Loupio","Phogleur","Mime Jr.","Wailmer","Mime Jr.","Poissirène","Doudouvet","Raikou","Farfaduvet","Rosélia","Limonde","Kaimorse","Pachirisu","Cochignon","Chuchmur","Goupix","Écrapince","Méditikka","Latias","Nosferalto","Séviper","Mysdibule","Barpau","Nostenfer","Milobellus","Galegon","Cresselia","Zarbi","Obalie","Têtarte","Poissoroy","Zekrom","Léviator","Stalgamin","Sharpedo","Mammochon","Sorbébé","Grelaçon","Grainipiot","Hypotrempe","Zigzaton","Regice","Linéon","Mesmérella","Galekid","Scrutella","Tartard","Gamblast","Tarpaud","Regigigas","Mystherbe","Rafflesia","Doduo","Joliflor","Stari","Colimucus","Tarinor","Sonistrelle","Ortide","Muplodocus","Kranidos","Lokhlass","Queulorior","Brindibou","Zigzaton","Plumeline","Registeel","Vorastérie","Hypocéan","Picassaut","Voltorbe","Passerouge","Électrode","Spectrum","Frison","Ectoplasma","Flingouste","Terhal","Entei","Nidoran♂","Géolithe","Rocabot","Rapasdepic","Rattata (Alola)","Bacabouh","Tadmorv (Alola)","Nymphali","Tylton","Caninos","Noeunoeuf","Nosferapti","Suicune","Manglouton","Altaria","Pichu","Crabagarre","Pikachu","Baudrive","Métamorph","Mimigal","Reshiram","Ramoloss","Feuforêve","Germignon","Sabelette (Alola)","Crocrodil","Araqua","Racaillou","Tarenbulle","Miaouss (Alola)","Kaiminus","Chamallot","Tiboudet","Gravalanch","Minidraco","Grolem","Nénupiot","Tarinorme","Amagara","Pierroteknik","Cadoizo","Xerneas","Moufflair","Zorua","Moufouette","Engloutyran","Lovdisc","Ho-Oh","Spoink","Scalpion","Groret","Katagami","Magnéti","Celebi","Yanma","Drascore","Goinfrex","Manzaï","Rapion","Polichombr","Kraknoix","Arkéapti","Groudon","Tritox","Charbi","Sinistrail","Nigosier"];var randomIndex=Math.floor(Math.random()*postsUrl.length);document.write('<a href="'+postsUrl[randomIndex]+'">'+postsTitle[randomIndex]+'</a>');}
function randomizeNextTarget()
{var unchaughtNumbers=["1","2","3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18","19","20","21","23","24","26","27","28","29","30","31","33","34","35","36","38","39","40","46","47","48","49","50","51","52","53","54","55","56","57","59","63","64","65","66","67","68","69","70","71","72","73","77","78","80","82","83","85","86","87","88","89","90","91","92","95","96","97","98","99","103","104","105","106","107","108","109","110","111","112","113","114","115","121","123","124","125","126","127","128","134","135","136","137","138","139","140","141","142","143","144","145","146","148","149","150","151","153","154","155","156","157","160","161","162","163","164","165","166","168","171","173","174","175","176","177","178","180","181","183","184","185","187","188","189","190","191","192","194","195","196","197","198","199","202","203","204","205","208","209","210","211","212","213","214","215","216","217","218","219","220","222","224","226","227","228","229","230","231","232","233","234","236","237","238","239","240","241","242","246","247","248","249","252","253","254","255","256","257","258","259","260","261","262","265","266","267","268","269","271","272","274","275","276","277","279","280","281","282","283","284","285","286","287","288","289","290","291","292","294","295","296","297","298","300","301","302","306","308","309","310","311","312","313","316","317","318","321","324","327","329","330","331","332","337","338","339","340","342","343","344","345","346","347","348","351","352","354","355","356","357","358","359","360","362","366","367","368","371","372","373","376","381","382","384","385","386","387","388","389","390","391","392","393","394","395","396","397","398","399","400","401","402","403","405","406","407","409","410","411","412","413","414","415","416","418","419","420","421","422","423","424","426","427","428","429","430","431","432","433","436","437","440","441","442","443","444","445","447","448","449","450","453","454","455","456","457","458","459","460","461","462","463","464","465","466","467","468","469","470","471","474","475","477","478","479","480","481","482","483","484","485","487","489","490","491","492","493","494","495","496","497","498","499","500","501","502","503","504","505","506","507","508","509","510","511","512","513","514","515","516","517","518","519","520","521","522","523","526","527","528","529","530","531","532","533","534","535","536","537","538","539","540","541","542","543","544","545","548","549","550","551","552","553","554","555","556","557","558","559","560","561","562","563","564","565","567","569","571","572","573","576","577","578","579","580","581","583","584","585","586","587","588","589","590","591","592","593","595","596","597","598","599","600","601","602","603","604","605","606","607","608","609","610","611","612","613","614","615","616","617","619","620","621","622","623","625","627","628","629","630","631","632","633","634","635","636","637","638","639","640","641","642","645","647","648","649","650","651","652","653","654","655","656","657","658","659","660","662","663","664","665","666","667","668","669","670","671","672","673","674","675","676","677","678","679","680","682","683","684","685","686","687","688","689","690","691","694","695","696","697","699","701","702","703","704","707","708","709","715","717","718","719","720","721","723","724","725","726","727","728","729","730","732","733","735","736","737","738","740","742","743","745","746","748","750","753","754","755","756","758","759","760","761","762","763","764","765","766","767","768","770","771","772","773","774","775","776","777","778","779","780","782","783","784","785","786","787","788","789","790","791","792","793","794","795","796","797","800","801","802","803","804","805","807","808","809","810","811","812","813","814","815","816","817","818","819","820","821","822","823","824","825","826","827","828","829","830","831","832","833","834","835","836","838","839","840","841","842","843","844","846","847","848","849","850","851","852","853","854","855","856","857","858","859","860","861","862","863","864","865","866","867","868","869","870","871","872","873","874","875","876","877","878","879","880","881","882","883","884","885","886","887","888","889","890","20a","26a","28a","37a","38a","50a","51a","53a","74a","75a","76a","89a","103a","105a","52g","77g","78g","83g","110g","122g","222g","263g","264g","554g","555g","562g","618g"];var unchaughtNames=["Bulbizarre","Herbizarre","Florizarre","Salamèche","Reptincel","Dracaufeu","Carapuce","Carabaffe","Tortank","Chenipan","Chrysacier","Papilusion","Aspicot","Coconfort","Dardargnan","Roucool","Roucoups","Roucarnage","Rattata","Rattatac","Piafabec","Abo","Arbok","Raichu","Sabelette","Sablaireau","Nidoran♀","Nidorina","Nidoqueen","Nidorino","Nidoking","Mélofée","Mélodelfe","Feunard","Rondoudou","Grodoudou","Paras","Parasect","Mimitoss","Aéromite","Taupiqueur","Triopikeur","Miaouss","Persian","Psykokwak","Akwakwak","Férosinge","Colossinge","Arcanin","Abra","Kadabra","Alakazam","Machoc","Machopeur","Mackogneur","Chétiflor","Boustiflor","Empiflor","Tentacool","Tentacruel","Ponyta","Galopa","Flagadoss","Magnéton","Canarticho","Dodrio","Otaria","Lamantine","Tadmorv","Grotadmorv","Kokiyas","Crustabri","Fantominus","Onix","Soporifik","Hypnomade","Krabby","Krabboss","Noadkoko","Osselait","Ossatueur","Kicklee","Tygnon","Excelangue","Smogo","Smogogo","Rhinocorne","Rhinoféros","Leveinard","Saquedeneu","Kangourex","Staross","Insécateur","Lippoutou","Élektek","Magmar","Scarabrute","Tauros","Aquali","Voltali","Pyroli","Porygon","Amonita","Amonistar","Kabuto","Kabutops","Ptéra","Ronflex","Artikodin","Électhor","Sulfura","Draco","Dracolosse","Mewtwo","Mew","Macronium","Méganium","Héricendre","Feurisson","Typhlosion","Aligatueur","Fouinette","Fouinar","Hoothoot","Noarfang","Coxy","Coxyclaque","Migalos","Lanturn","Mélo","Toudoudou","Togepi","Togetic","Natu","Xatu","Lainergie","Pharamp","Marill","Azumarill","Simularbre","Granivol","Floravol","Cotovol","Capumain","Tournegrin","Héliatronc","Axoloto","Maraiste","Mentali","Noctali","Cornèbre","Roigada","Qulbutoké","Girafarig","Pomdepik","Foretress","Steelix","Snubbull","Granbull","Qwilfish","Cizayox","Caratroc","Scarhino","Farfuret","Teddiursa","Ursaring","Limagma","Volcaropod","Marcacrin","Corayon","Octillery","Démanta","Airmure","Malosse","Démolosse","Hyporoi","Phanpy","Donphan","Porygon2","Cerfrousse","Debugant","Kapoera","Lippouti","Élekid","Magby","Écrémeuh","Leuphorie","Embrylex","Ymphect","Tyranocif","Lugia","Arcko","Massko","Jungko","Poussifeu","Galifeu","Braségali","Gobou","Flobio","Laggron","Medhyèna","Grahyèna","Chenipotte","Armulys","Charmillon","Blindalys","Papinox","Lombre","Ludicolo","Pifeuil","Tengalice","Nirondelle","Hélédelle","Bekipan","Tarsal","Kirlia","Gardevoir","Arakdo","Maskadra","Balignon","Chapignon","Parecool","Vigoroth","Monaflèmit","Ningale","Ninjask","Munja","Ramboum","Brouhabam","Makuhita","Hariyama","Azurill","Skitty","Delcatty","Ténéfix","Galeking","Charmina","Dynavolt","Élecsprint","Posipi","Négapi","Muciole","Gloupti","Avaltout","Carvanha","Wailord","Chartor","Spinda","Vibraninf","Libégon","Cacnea","Cacturne","Séléroc","Solaroc","Barloche","Barbicha","Colhomard","Balbuto","Kaorine","Lilia","Vacilys","Anorith","Armaldo","Morphéo","Kecleon","Branette","Skelénox","Téraclope","Tropius","Éoko","Absol","Okéoké","Oniglali","Coquiperl","Serpang","Rosabyss","Draby","Drackhaus","Drattak","Métalosse","Latios","Kyogre","Rayquaza","Jirachi","Deoxys","Tortipouss","Boskara","Torterra","Ouisticram","Chimpenfeu","Simiabraz","Tiplouf","Prinplouf","Pingoléon","Étourmi","Étourvol","Étouraptor","Keunotor","Castorno","Crikzik","Mélokrik","Lixy","Luxray","Rozbouton","Roserade","Charkos","Dinoclier","Bastiodon","Cheniti","Cheniselle","Papilord","Apitrini","Apireine","Mustébouée","Mustéflott","Ceribou","Ceriflor","Sancoki","Tritosor","Capidextre","Grodrive","Laporeille","Lockpin","Magirêve","Corboss","Chaglam","Chaffreux","Korillon","Archéomire","Archéodong","Ptiravi","Pijako","Spiritomb","Griknot","Carmache","Carchacrok","Riolu","Lucario","Hippopotas","Hippodocus","Cradopaud","Coatox","Vortente","Écayon","Luminéon","Babimanta","Blizzi","Blizzaroi","Dimoret","Magnézone","Coudlangue","Rhinastoc","Bouldeneu","Élekable","Maganon","Togekiss","Yanmega","Phyllali","Givrali","Porygon-Z","Gallame","Noctunoir","Momartik","Motisma","Créhelf","Créfollet","Créfadet","Dialga","Palkia","Heatran","Giratina","Phione","Manaphy","Darkrai","Shaymin","Arceus","Victini","Vipélierre","Lianaja","Majaspic","Gruikui","Grotichon","Roitiflam","Moustillon","Mateloutre","Clamiral","Ratentif","Miradar","Ponchiot","Ponchien","Mastouffe","Chacripan","Léopardus","Feuillajou","Feuiloutan","Flamajou","Flamoutan","Flotajou","Flotoutan","Munna","Mushana","Poichigeon","Colombeau","Déflaisan","Zébibron","Zéblitz","Gigalithe","Chovsourir","Rhinolove","Rototaupe","Minotaupe","Nanméouïe","Charpenti","Ouvrifier","Bétochef","Tritonde","Batracné","Crapustule","Judokrak","Karaclée","Larveyette","Couverdure","Manternel","Venipatte","Scobolide","Brutapode","Chlorobule","Fragilady","Bargantua","Mascaïman","Escroco","Crocorible","Darumarond","Darumacho","Maracachi","Crabicoque","Crabaraque","Baggiguane","Baggaïd","Cryptéro","Tutafeh","Tutankafer","Carapagos","Mégapagos","Aéroptéryx","Miasmax","Zoroark","Chinchidou","Pashmilla","Sidérella","Nucléos","Méios","Symbios","Couaneton","Lakmécygne","Sorboul","Sorbouboul","Vivaldaim","Haydaim","Emolga","Carabing","Lançargot","Trompignon","Gaulet","Viskuse","Moyade","Statitik","Mygavolt","Grindur","Noacier","Tic","Clic","Cliticlic","Anchwatt","Lampéroie","Ohmassacre","Lewsor","Neitram","Funécire","Mélancolux","Lugulabre","Coupenotte","Incisache","Tranchodon","Polarhume","Polagriffe","Hexagel","Escargaume","Limaspeed","Kungfouine","Shaofouine","Drakkarmin","Gringolem","Golemastoc","Scalproie","Furaiglon","Gueriaigle","Vostourno","Vaututrice","Aflamanoir","Fermite","Solochi","Diamat","Trioxhydre","Pyronille","Pyrax","Cobaltium","Terrakium","Viridium","Boréas","Fulguris","Démétéros","Keldeo","Meloetta","Genesect","Marisson","Boguérisse","Blindépique","Feunnec","Roussil","Goupelin","Grenousse","Croâporal","Amphinobi","Sapereau","Excavarenne","Braisillon","Flambusard","Lépidonille","Pérégrain","Prismillon","Hélionceau","Némélios","Flabébé","Floette","Florges","Cabriolaine","Chevroum","Pandespiègle","Pandarbare","Couafarel","Psystigri","Mistigrix","Monorpale","Dimoclès","Fluvetin","Cocotine","Sucroquin","Cupcanaille","Sepiatop","Sepiatroce","Opermine","Golgopathe","Venalgue","Kravarech","Galvaran","Iguolta","Ptyranidur","Rexillius","Dragmara","Brutalibré","Dedenne","Strassie","Mucuscule","Trousselin","Brocélôme","Desséliande","Bruyverne","Yveltal","Zygarde","Diancie","Hoopa","Volcanion","Efflèche","Archéduc","Flamiaou","Matoufeu","Félinferno","Otaquin","Otarlette","Oratoria","Piclairon","Bazoucan","Argouste","Larvibule","Chrysapile","Lucanon","Crabominable","Bombydou","Rubombelle","Lougaroc","Froussardine","Prédastérie","Bourrinos","Mimantis","Floramantis","Spododo","Lampignon","Malamandre","Nounourson","Chelours","Croquine","Candine","Sucreine","Guérilande","Gouroutan","Quartermac","Sovkipou","Sarmuraï","Trépassable","Concombaffe","Type:0","Silvallié","Météno","Dodoala","Boumata","Togedemaru","Mimiqui","Denticrisse","Draïeul","Bébécaille","Écaïd","Ékaïser","Tokorico","Tokopiyon","Tokotoro","Tokopisco","Cosmog","Cosmovum","Solgaleo","Lunala","Zéroïd","Mouscoto","Cancrelove","Câblifère","Bamboiselle","Necrozma","Magearna","Marshadow","Vémini","Mandrillon","Ama-Ama","Zeraora","Meltan","Melmetal","Ouistempo","Badabouin","Gorythmic","Flambino","Lapyro","Pyrobut","Larméléon","Arrozard","Lézargus","Rongourmand","Rongrigou","Minisange","Bleuseille","Corvaillus","Larvadar","Coléodôme","Astronelle","Goupilou","Roublenard","Tournicoton","Blancoton","Moumouton","Moumouflon","Khélocrok","Torgamord","Voltoutou","Fulgudog","Wagomine","Monthracite","Verpom","Pomdrapi","Dratatin","Dunaja","Dunaconda","Embrochet","Hastacuda","Toxizap","Salarsen","Grillepattes","Scolocendre","Poulpaf","Krakos","Théffroi","Polthégeist","Bibichut","Chapotus","Sorcilence","Grimalin","Fourbelin","Angoliath","Ixon","Berserkatt","Corayôme","Palarticho","M. Glaquette","Tutétékri","Crèmy","Charmilly","Hexadron","Wattapik","Frissonille","Beldeneige","Dolman","Bekaglaçon","Wimessir","Morpeko","Charibari","Pachyradjah","Galvagon","Galvagla","Hydragon","Hydragla","Duralugon","Fantyrm","Dispareptil","Lanssorien","Zacian","Zamazenta","Éthernatos","Rattatac (Alola)","Raichu (Alola)","Sablaireau (Alola)","Goupix (Alola)","Feunard (Alola)","Taupiqueur (Alola)","Triopikeur (Alola)","Persian (Alola)","Racaillou (Alola)","Gravalanch (Alola)","Grolem (Alola)","Grotadmorv (Alola)","Noadkoko (Alola)","Ossatueur (Alola)","Miaouss (Galar)","Ponyta (Galar)","Galopa (Galar)","Canarticho (Galar)","Smogogo (Galar)","M. Mime (Galar)","Corayon (Galar)","Zigzaton (Galar)","Linéon (Galar)","Darumarond (Galar)","Darumacho (Galar)","Tutafeh (Galar)","Limonde (Galar)"];var randomIndex=Math.floor(Math.random()*unchaughtNumbers.length);document.write(unchaughtNumbers[randomIndex]+' - '+unchaughtNames[randomIndex]);}