function randomizePost()
{var postsUrl=["/ChromaListe/posts/2023-01-04-amassel.html","/ChromaListe/posts/2023-01-03-tapatoes.html","/ChromaListe/posts/2023-01-02-granivol.html","/ChromaListe/posts/2022-12-25-dofin.html","/ChromaListe/posts/2022-12-25-mucuscule.html","/ChromaListe/posts/2022-12-25-chevroum.html","/ChromaListe/posts/2022-12-12-scalproie.html","/ChromaListe/posts/2022-12-05-selutin.html","/ChromaListe/posts/2022-12-05-grodrive.html","/ChromaListe/posts/2022-12-05-scarhino.html","/ChromaListe/posts/2022-12-03-fort-ivoire.html","/ChromaListe/posts/2022-11-28-terracool.html","/ChromaListe/posts/2022-11-28-floramantis.html","/ChromaListe/posts/2022-11-28-foretress.html","/ChromaListe/posts/2022-11-26-motorizard.html","/ChromaListe/posts/2022-11-19-candine.html","/ChromaListe/posts/2022-11-19-pachirisu.html","/ChromaListe/posts/2022-10-29-piclairon.html","/ChromaListe/posts/2022-10-29-blizzi.html","/ChromaListe/posts/2022-10-24-emolga.html","/ChromaListe/posts/2022-02-16-mustebouee.html","/ChromaListe/posts/2022-02-14-chaglam.html","/ChromaListe/posts/2022-02-13-nosferapti.html","/ChromaListe/posts/2022-02-05-lixy.html","/ChromaListe/posts/2022-02-03-etourmi.html","/ChromaListe/posts/2022-02-02-luxray.html","/ChromaListe/posts/2022-01-29-luxio.html","/ChromaListe/posts/2022-01-28-nostenfer.html","/ChromaListe/posts/2021-12-06-tokotoro.html","/ChromaListe/posts/2021-11-28-porygon.html","/ChromaListe/posts/2021-11-18-crabaraque.html","/ChromaListe/posts/2021-11-15-triopikeur-alola.html","/ChromaListe/posts/2021-11-11-berserkatt.html","/ChromaListe/posts/2021-11-09-momartik.html","/ChromaListe/posts/2021-11-08-excavarene.html","/ChromaListe/posts/2021-10-31-maracachi.html","/ChromaListe/posts/2020-11-01-necrozma.html","/ChromaListe/posts/2020-10-31-larvibule.html","/ChromaListe/posts/2020-10-26-sorboul.html","/ChromaListe/posts/2020-10-26-gigalithe.html","/ChromaListe/posts/2020-10-24-regidrago.html","/ChromaListe/posts/2020-07-04-trepassable.html","/ChromaListe/posts/2020-05-15-flamiaou.html","/ChromaListe/posts/2020-03-07-zigzaton-galar.html","/ChromaListe/posts/2020-01-21-tournicoton.html","/ChromaListe/posts/2020-01-04-nigosier.html","/ChromaListe/posts/2019-12-21-sinistrail.html","/ChromaListe/posts/2019-12-14-charbi.html","/ChromaListe/posts/2018-12-05-tritox.html","/ChromaListe/posts/2018-12-03-groudon.html","/ChromaListe/posts/2018-02-13-celebi.html","/ChromaListe/posts/2018-01-07-katagami.html","/ChromaListe/posts/2017-12-17-scalpion.html","/ChromaListe/posts/2017-12-14-ho-oh.html","/ChromaListe/posts/2017-12-03-engloutyran.html","/ChromaListe/posts/2017-11-30-zorua.html","/ChromaListe/posts/2017-11-28-xerneas.html","/ChromaListe/posts/2017-11-26-pierroteknik.html","/ChromaListe/posts/2017-11-21-arkeapti.html","/ChromaListe/posts/2017-11-05-kraknoix.html","/ChromaListe/posts/2017-10-31-polichombr.html","/ChromaListe/posts/2017-10-29-drascore.html","/ChromaListe/posts/2017-10-29-rapion.html","/ChromaListe/posts/2017-10-29-goinfrex.html","/ChromaListe/posts/2017-10-29-manzai.html","/ChromaListe/posts/2017-10-28-grolem.html","/ChromaListe/posts/2017-10-28-gravalanch.html","/ChromaListe/posts/2017-10-28-tarinorme.html","/ChromaListe/posts/2017-10-28-yanma.html","/ChromaListe/posts/2017-10-24-chamallot.html","/ChromaListe/posts/2017-10-22-miaouss-alola.html","/ChromaListe/posts/2017-10-19-racaillou.html","/ChromaListe/posts/2017-10-17-crocrodil.html","/ChromaListe/posts/2017-10-09-germignon.html","/ChromaListe/posts/2017-09-30-magneti.html","/ChromaListe/posts/2017-09-30-groret.html","/ChromaListe/posts/2017-09-29-spoink.html","/ChromaListe/posts/2017-09-28-lovdisc.html","/ChromaListe/posts/2017-09-25-moufflair.html","/ChromaListe/posts/2017-09-25-moufouette.html","/ChromaListe/posts/2017-09-25-cadoizo.html","/ChromaListe/posts/2017-09-22-amagara.html","/ChromaListe/posts/2017-09-12-ramoloss.html","/ChromaListe/posts/2017-09-12-mimigal.html","/ChromaListe/posts/2017-09-10-baudrive.html","/ChromaListe/posts/2017-09-08-crabagarre.html","/ChromaListe/posts/2017-09-02-altaria.html","/ChromaListe/posts/2017-06-05-suicune.html","/ChromaListe/posts/2017-05-30-noeunoeuf.html","/ChromaListe/posts/2017-05-22-tylton.html","/ChromaListe/posts/2017-05-21-nenupiot.html","/ChromaListe/posts/2017-05-21-minidraco.html","/ChromaListe/posts/2017-05-07-tiboudet.html","/ChromaListe/posts/2017-04-28-kaiminus.html","/ChromaListe/posts/2017-04-16-tarenbulle.html","/ChromaListe/posts/2017-04-01-araqua.html","/ChromaListe/posts/2017-03-26-sabelette-alola.html","/ChromaListe/posts/2017-03-14-feuforeve.html","/ChromaListe/posts/2017-03-11-tadmorv-alola.html","/ChromaListe/posts/2017-03-08-rattata-alola.html","/ChromaListe/posts/2017-03-04-rocabot.html","/ChromaListe/posts/2017-02-23-nidoran.html","/ChromaListe/posts/2017-02-19-terhal.html","/ChromaListe/posts/2017-02-17-ectoplasma.html","/ChromaListe/posts/2017-02-15-spectrum.html","/ChromaListe/posts/2017-02-11-passerouge.html","/ChromaListe/posts/2017-02-05-reshiram.html","/ChromaListe/posts/2017-02-04-metamorph.html","/ChromaListe/posts/2017-02-03-pikachu.html","/ChromaListe/posts/2017-02-03-pichu.html","/ChromaListe/posts/2017-01-31-manglouton.html","/ChromaListe/posts/2017-01-26-nosferapti.html","/ChromaListe/posts/2017-01-21-caninos.html","/ChromaListe/posts/2017-01-11-nymphali.html","/ChromaListe/posts/2016-12-22-picassaut.html","/ChromaListe/posts/2016-12-19-vorasterie.html","/ChromaListe/posts/2016-12-17-plumeline.html","/ChromaListe/posts/2016-12-16-brindibou.html","/ChromaListe/posts/2016-12-11-bacabouh.html","/ChromaListe/posts/2016-12-07-rapasdepic.html","/ChromaListe/posts/2016-11-22-geolithe.html","/ChromaListe/posts/2016-10-08-entei.html","/ChromaListe/posts/2016-08-26-lokhlass.html","/ChromaListe/posts/2016-08-20-muplodocus.html","/ChromaListe/posts/2016-08-14-sonistrelle.html","/ChromaListe/posts/2016-08-14-colimucus.html","/ChromaListe/posts/2016-07-18-joliflor.html","/ChromaListe/posts/2016-06-06-rafflesia.html","/ChromaListe/posts/2016-04-21-regigigas.html","/ChromaListe/posts/2016-04-19-gamblast.html","/ChromaListe/posts/2016-04-14-flingouste.html","/ChromaListe/posts/2016-04-07-frison.html","/ChromaListe/posts/2016-03-27-electrode.html","/ChromaListe/posts/2016-03-26-voltorbe.html","/ChromaListe/posts/2016-03-23-hypocean.html","/ChromaListe/posts/2016-03-21-registeel.html","/ChromaListe/posts/2016-03-13-zigzaton.html","/ChromaListe/posts/2016-03-12-queulorior.html","/ChromaListe/posts/2016-03-11-mesmerella.html","/ChromaListe/posts/2016-03-11-scrutella.html","/ChromaListe/posts/2016-03-08-regice.html","/ChromaListe/posts/2016-02-26-hypotrempe.html","/ChromaListe/posts/2016-02-20-kranidos.html","/ChromaListe/posts/2015-10-16-ortide.html","/ChromaListe/posts/2015-10-14-tarinor.html","/ChromaListe/posts/2015-10-14-stari.html","/ChromaListe/posts/2015-10-11-grelacon.html","/ChromaListe/posts/2015-10-07-mammochon.html","/ChromaListe/posts/2015-10-06-stalgamin.html","/ChromaListe/posts/2015-09-30-zekrom.html","/ChromaListe/posts/2015-08-21-doduo.html","/ChromaListe/posts/2015-08-10-mystherbe.html","/ChromaListe/posts/2015-07-10-tarpaud.html","/ChromaListe/posts/2015-07-08-tartard.html","/ChromaListe/posts/2015-07-07-tetarte.html","/ChromaListe/posts/2015-07-02-zarbi.html","/ChromaListe/posts/2015-06-21-galegon.html","/ChromaListe/posts/2015-06-20-mysdibule.html","/ChromaListe/posts/2015-06-20-nostenfer.html","/ChromaListe/posts/2015-06-18-nosferalto.html","/ChromaListe/posts/2015-06-18-galekid.html","/ChromaListe/posts/2015-06-17-lineon.html","/ChromaListe/posts/2015-06-15-zigzaton.html","/ChromaListe/posts/2015-06-12-grainipiot.html","/ChromaListe/posts/2015-05-23-meditikka.html","/ChromaListe/posts/2015-05-20-goupix.html","/ChromaListe/posts/2015-05-17-cochignon.html","/ChromaListe/posts/2015-05-01-kaimorse.html","/ChromaListe/posts/2015-04-24-roselia.html","/ChromaListe/posts/2015-04-18-raikou.html","/ChromaListe/posts/2015-04-04-sorbebe.html","/ChromaListe/posts/2015-04-03-sharpedo.html","/ChromaListe/posts/2015-04-02-leviator.html","/ChromaListe/posts/2015-04-01-poissoroy.html","/ChromaListe/posts/2015-04-01-poissirene.html","/ChromaListe/posts/2015-03-30-wailmer.html","/ChromaListe/posts/2015-03-27-phogleur.html","/ChromaListe/posts/2015-03-24-nosferapti.html","/ChromaListe/posts/2015-03-22-cresselia.html","/ChromaListe/posts/2015-03-22-obalie.html","/ChromaListe/posts/2015-02-24-milobellus.html","/ChromaListe/posts/2015-02-20-barpau.html","/ChromaListe/posts/2015-02-09-seviper.html","/ChromaListe/posts/2015-01-28-latias.html","/ChromaListe/posts/2015-01-20-miamiasme.html","/ChromaListe/posts/2015-01-19-kyurem.html","/ChromaListe/posts/2014-12-30-regirock.html","/ChromaListe/posts/2014-12-28-mangriff.html","/ChromaListe/posts/2014-12-16-ecrapince.html","/ChromaListe/posts/2014-10-23-chuchmur.html","/ChromaListe/posts/2014-10-18-wattouat.html","/ChromaListe/posts/2014-09-15-camerupt.html","/ChromaListe/posts/2014-09-07-limonde.html","/ChromaListe/posts/2014-09-07-pachirisu.html","/ChromaListe/posts/2014-09-06-luxio.html","/ChromaListe/posts/2014-08-29-farfaduvet.html","/ChromaListe/posts/2014-08-17-doudouvet.html","/ChromaListe/posts/2014-08-12-metang.html","/ChromaListe/posts/2014-08-12-goelise.html","/ChromaListe/posts/2014-08-06-nodulithe.html","/ChromaListe/posts/2014-08-05-mime-jr.html","/ChromaListe/posts/2014-08-05-m-mime-galar.html","/ChromaListe/posts/2014-08-03-remoraid.html","/ChromaListe/posts/2014-08-03-loupio.html","/ChromaListe/posts/2014-08-02-mamanbo.html","/ChromaListe/posts/2014-07-26-ptitard.html","/ChromaListe/posts/2014-07-03-evoli.html","/ChromaListe/posts/2014-05-07-banshitrouye.html","/ChromaListe/posts/2014-04-21-pitrouille.html","/ChromaListe/posts/2014-04-19-scorvol.html","/ChromaListe/posts/2014-03-22-scorplane.html","/ChromaListe/posts/2014-03-07-exagide.html","/ChromaListe/posts/2014-03-02-lumivole.html","/ChromaListe/posts/2014-02-21-magicarpe.html","/ChromaListe/posts/2014-02-09-m-mime.html","/ChromaListe/posts/2014-02-07-insolourdo.html","/ChromaListe/posts/2013-10-27-relicanth.html","/ChromaListe/posts/2013-10-13-seracrawl.html"];var postsTitle=["Amassel","Tapatoès","Granivol","Dofin","Mucuscule","Chevroum","Scalproie","Selutin","Grodrive","Scarhino","Fort-Ivoire","Terracool","Floramantis","Foretress","Motorizard","Candine","Pachirisu","Piclairon","Blizzi","Emolga","Mustébouée","Chaglam","Nosferapti","Lixy","Étourmi","Luxray","Luxio","Nostenfer","Tokotoro","Porygon","Crabaraque","Triopikeur (Alola)","Berserkatt","Momartik","Excavarenne","Maracachi","Necrozma","Larvibule","Sorboul","Gigalithe","Regidrago","Trépassable","Flamiaou","Zigzaton (Galar)","Tournicoton","Nigosier","Sinistrail","Charbi","Tritox","Groudon","Celebi","Katagami","Scalpion","Ho-Oh","Engloutyran","Zorua","Xerneas","Pierroteknik","Arkéapti","Kraknoix","Polichombr","Drascore","Rapion","Goinfrex","Manzaï","Grolem","Gravalanch","Tarinorme","Yanma","Chamallot","Miaouss (Alola)","Racaillou","Crocrodil","Germignon","Magnéti","Groret","Spoink","Lovdisc","Moufflair","Moufouette","Cadoizo","Amagara","Ramoloss","Mimigal","Baudrive","Crabagarre","Altaria","Suicune","Noeunoeuf","Tylton","Nénupiot","Minidraco","Tiboudet","Kaiminus","Tarenbulle","Araqua","Sabelette (Alola)","Feuforêve","Tadmorv (Alola)","Rattata (Alola)","Rocabot","Nidoran♂","Terhal","Ectoplasma","Spectrum","Passerouge","Reshiram","Métamorph","Pikachu","Pichu","Manglouton","Nosferapti","Caninos","Nymphali","Picassaut","Vorastérie","Plumeline","Brindibou","Bacabouh","Rapasdepic","Géolithe","Entei","Lokhlass","Muplodocus","Sonistrelle","Colimucus","Joliflor","Rafflesia","Regigigas","Gamblast","Flingouste","Frison","Électrode","Voltorbe","Hypocéan","Registeel","Zigzaton","Queulorior","Mesmérella","Scrutella","Regice","Hypotrempe","Kranidos","Ortide","Tarinor","Stari","Grelaçon","Mammochon","Stalgamin","Zekrom","Doduo","Mystherbe","Tarpaud","Tartard","Têtarte","Zarbi","Galegon","Mysdibule","Nostenfer","Nosferalto","Galekid","Linéon","Zigzaton","Grainipiot","Méditikka","Goupix","Cochignon","Kaimorse","Rosélia","Raikou","Sorbébé","Sharpedo","Léviator","Poissoroy","Poissirène","Wailmer","Phogleur","Nosferapti","Cresselia","Obalie","Milobellus","Barpau","Séviper","Latias","Miamiasme","Kyurem","Regirock","Mangriff","Écrapince","Chuchmur","Wattouat","Camérupt","Limonde","Pachirisu","Luxio","Farfaduvet","Doudouvet","Métang","Goélise","Nodulithe","Mime Jr.","M. Mime (Galar)","Rémoraid","Loupio","Mamanbo","Ptitard","Évoli","Banshitrouye","Pitrouille","Scorvol","Scorplane","Exagide","Lumivole","Magicarpe","M. Mime","Insolourdo","Relicanth","Séracrawl"];var randomIndex=Math.floor(Math.random()*postsUrl.length);$("#randomPostLink").attr('href',postsUrl[randomIndex]);$("#randomPostLink").html(postsTitle[randomIndex]);}
function updateSearchResults(){var idx=lunr(function(){this.field('id');this.field('title');this.field('url');for(var key in window.store){this.add({'id':key,'title':window.store[key].title,'url':window.store[key].url});}});var squery=$("#searchInput").val().toLowerCase();var resultsX=idx.search('*'+squery+'*');var tooltips='';var results=0;if(resultsX.length>0&&squery.length>=2){for(var i=0;i<resultsX.length;i++){var item=store[resultsX[i].ref];tooltips+='<a href="'+item.url+'">'+item.title+'</a>';results++;}
if(results==0){tooltips="<em>Aucun résultats</em>";}
$("#searchResults").fadeIn(222);}else{if(squery.length>2){tooltips="<em>Aucun résultats</em>";$("#searchResults").fadeIn(222);}else{$("#searchResults").fadeOut(222);}}
$("#searchResults").html(tooltips);}
$(document).ready(function(){window.store={"Amassel":{"title":"Amassel","url":"/ChromaListe/posts/2023-01-04-amassel.html"},"Tapatoès":{"title":"Tapatoès","url":"/ChromaListe/posts/2023-01-03-tapatoes.html"},"Granivol":{"title":"Granivol","url":"/ChromaListe/posts/2023-01-02-granivol.html"},"Dofin":{"title":"Dofin","url":"/ChromaListe/posts/2022-12-25-dofin.html"},"Mucuscule":{"title":"Mucuscule","url":"/ChromaListe/posts/2022-12-25-mucuscule.html"},"Chevroum":{"title":"Chevroum","url":"/ChromaListe/posts/2022-12-25-chevroum.html"},"Scalproie":{"title":"Scalproie","url":"/ChromaListe/posts/2022-12-12-scalproie.html"},"Selutin":{"title":"Selutin","url":"/ChromaListe/posts/2022-12-05-selutin.html"},"Grodrive":{"title":"Grodrive","url":"/ChromaListe/posts/2022-12-05-grodrive.html"},"Scarhino":{"title":"Scarhino","url":"/ChromaListe/posts/2022-12-05-scarhino.html"},"Fort-Ivoire":{"title":"Fort-Ivoire","url":"/ChromaListe/posts/2022-12-03-fort-ivoire.html"},"Terracool":{"title":"Terracool","url":"/ChromaListe/posts/2022-11-28-terracool.html"},"Floramantis":{"title":"Floramantis","url":"/ChromaListe/posts/2022-11-28-floramantis.html"},"Foretress":{"title":"Foretress","url":"/ChromaListe/posts/2022-11-28-foretress.html"},"Motorizard":{"title":"Motorizard","url":"/ChromaListe/posts/2022-11-26-motorizard.html"},"Candine":{"title":"Candine","url":"/ChromaListe/posts/2022-11-19-candine.html"},"Pachirisu":{"title":"Pachirisu","url":"/ChromaListe/posts/2022-11-19-pachirisu.html"},"Piclairon":{"title":"Piclairon","url":"/ChromaListe/posts/2022-10-29-piclairon.html"},"Blizzi":{"title":"Blizzi","url":"/ChromaListe/posts/2022-10-29-blizzi.html"},"Emolga":{"title":"Emolga","url":"/ChromaListe/posts/2022-10-24-emolga.html"},"Mustébouée":{"title":"Mustébouée","url":"/ChromaListe/posts/2022-02-16-mustebouee.html"},"Chaglam":{"title":"Chaglam","url":"/ChromaListe/posts/2022-02-14-chaglam.html"},"Nosferapti":{"title":"Nosferapti","url":"/ChromaListe/posts/2022-02-13-nosferapti.html"},"Lixy":{"title":"Lixy","url":"/ChromaListe/posts/2022-02-05-lixy.html"},"Étourmi":{"title":"Étourmi","url":"/ChromaListe/posts/2022-02-03-etourmi.html"},"Luxray":{"title":"Luxray","url":"/ChromaListe/posts/2022-02-02-luxray.html"},"Luxio":{"title":"Luxio","url":"/ChromaListe/posts/2022-01-29-luxio.html"},"Nostenfer":{"title":"Nostenfer","url":"/ChromaListe/posts/2022-01-28-nostenfer.html"},"Tokotoro":{"title":"Tokotoro","url":"/ChromaListe/posts/2021-12-06-tokotoro.html"},"Porygon":{"title":"Porygon","url":"/ChromaListe/posts/2021-11-28-porygon.html"},"Crabaraque":{"title":"Crabaraque","url":"/ChromaListe/posts/2021-11-18-crabaraque.html"},"Triopikeur (Alola)":{"title":"Triopikeur (Alola)","url":"/ChromaListe/posts/2021-11-15-triopikeur-alola.html"},"Berserkatt":{"title":"Berserkatt","url":"/ChromaListe/posts/2021-11-11-berserkatt.html"},"Momartik":{"title":"Momartik","url":"/ChromaListe/posts/2021-11-09-momartik.html"},"Excavarenne":{"title":"Excavarenne","url":"/ChromaListe/posts/2021-11-08-excavarene.html"},"Maracachi":{"title":"Maracachi","url":"/ChromaListe/posts/2021-10-31-maracachi.html"},"Necrozma":{"title":"Necrozma","url":"/ChromaListe/posts/2020-11-01-necrozma.html"},"Larvibule":{"title":"Larvibule","url":"/ChromaListe/posts/2020-10-31-larvibule.html"},"Sorboul":{"title":"Sorboul","url":"/ChromaListe/posts/2020-10-26-sorboul.html"},"Gigalithe":{"title":"Gigalithe","url":"/ChromaListe/posts/2020-10-26-gigalithe.html"},"Regidrago":{"title":"Regidrago","url":"/ChromaListe/posts/2020-10-24-regidrago.html"},"Trépassable":{"title":"Trépassable","url":"/ChromaListe/posts/2020-07-04-trepassable.html"},"Flamiaou":{"title":"Flamiaou","url":"/ChromaListe/posts/2020-05-15-flamiaou.html"},"Zigzaton (Galar)":{"title":"Zigzaton (Galar)","url":"/ChromaListe/posts/2020-03-07-zigzaton-galar.html"},"Tournicoton":{"title":"Tournicoton","url":"/ChromaListe/posts/2020-01-21-tournicoton.html"},"Nigosier":{"title":"Nigosier","url":"/ChromaListe/posts/2020-01-04-nigosier.html"},"Sinistrail":{"title":"Sinistrail","url":"/ChromaListe/posts/2019-12-21-sinistrail.html"},"Charbi":{"title":"Charbi","url":"/ChromaListe/posts/2019-12-14-charbi.html"},"Tritox":{"title":"Tritox","url":"/ChromaListe/posts/2018-12-05-tritox.html"},"Groudon":{"title":"Groudon","url":"/ChromaListe/posts/2018-12-03-groudon.html"},"Celebi":{"title":"Celebi","url":"/ChromaListe/posts/2018-02-13-celebi.html"},"Katagami":{"title":"Katagami","url":"/ChromaListe/posts/2018-01-07-katagami.html"},"Scalpion":{"title":"Scalpion","url":"/ChromaListe/posts/2017-12-17-scalpion.html"},"Ho-Oh":{"title":"Ho-Oh","url":"/ChromaListe/posts/2017-12-14-ho-oh.html"},"Engloutyran":{"title":"Engloutyran","url":"/ChromaListe/posts/2017-12-03-engloutyran.html"},"Zorua":{"title":"Zorua","url":"/ChromaListe/posts/2017-11-30-zorua.html"},"Xerneas":{"title":"Xerneas","url":"/ChromaListe/posts/2017-11-28-xerneas.html"},"Pierroteknik":{"title":"Pierroteknik","url":"/ChromaListe/posts/2017-11-26-pierroteknik.html"},"Arkéapti":{"title":"Arkéapti","url":"/ChromaListe/posts/2017-11-21-arkeapti.html"},"Kraknoix":{"title":"Kraknoix","url":"/ChromaListe/posts/2017-11-05-kraknoix.html"},"Polichombr":{"title":"Polichombr","url":"/ChromaListe/posts/2017-10-31-polichombr.html"},"Drascore":{"title":"Drascore","url":"/ChromaListe/posts/2017-10-29-drascore.html"},"Rapion":{"title":"Rapion","url":"/ChromaListe/posts/2017-10-29-rapion.html"},"Goinfrex":{"title":"Goinfrex","url":"/ChromaListe/posts/2017-10-29-goinfrex.html"},"Manzaï":{"title":"Manzaï","url":"/ChromaListe/posts/2017-10-29-manzai.html"},"Grolem":{"title":"Grolem","url":"/ChromaListe/posts/2017-10-28-grolem.html"},"Gravalanch":{"title":"Gravalanch","url":"/ChromaListe/posts/2017-10-28-gravalanch.html"},"Tarinorme":{"title":"Tarinorme","url":"/ChromaListe/posts/2017-10-28-tarinorme.html"},"Yanma":{"title":"Yanma","url":"/ChromaListe/posts/2017-10-28-yanma.html"},"Chamallot":{"title":"Chamallot","url":"/ChromaListe/posts/2017-10-24-chamallot.html"},"Miaouss (Alola)":{"title":"Miaouss (Alola)","url":"/ChromaListe/posts/2017-10-22-miaouss-alola.html"},"Racaillou":{"title":"Racaillou","url":"/ChromaListe/posts/2017-10-19-racaillou.html"},"Crocrodil":{"title":"Crocrodil","url":"/ChromaListe/posts/2017-10-17-crocrodil.html"},"Germignon":{"title":"Germignon","url":"/ChromaListe/posts/2017-10-09-germignon.html"},"Magnéti":{"title":"Magnéti","url":"/ChromaListe/posts/2017-09-30-magneti.html"},"Groret":{"title":"Groret","url":"/ChromaListe/posts/2017-09-30-groret.html"},"Spoink":{"title":"Spoink","url":"/ChromaListe/posts/2017-09-29-spoink.html"},"Lovdisc":{"title":"Lovdisc","url":"/ChromaListe/posts/2017-09-28-lovdisc.html"},"Moufflair":{"title":"Moufflair","url":"/ChromaListe/posts/2017-09-25-moufflair.html"},"Moufouette":{"title":"Moufouette","url":"/ChromaListe/posts/2017-09-25-moufouette.html"},"Cadoizo":{"title":"Cadoizo","url":"/ChromaListe/posts/2017-09-25-cadoizo.html"},"Amagara":{"title":"Amagara","url":"/ChromaListe/posts/2017-09-22-amagara.html"},"Ramoloss":{"title":"Ramoloss","url":"/ChromaListe/posts/2017-09-12-ramoloss.html"},"Mimigal":{"title":"Mimigal","url":"/ChromaListe/posts/2017-09-12-mimigal.html"},"Baudrive":{"title":"Baudrive","url":"/ChromaListe/posts/2017-09-10-baudrive.html"},"Crabagarre":{"title":"Crabagarre","url":"/ChromaListe/posts/2017-09-08-crabagarre.html"},"Altaria":{"title":"Altaria","url":"/ChromaListe/posts/2017-09-02-altaria.html"},"Suicune":{"title":"Suicune","url":"/ChromaListe/posts/2017-06-05-suicune.html"},"Noeunoeuf":{"title":"Noeunoeuf","url":"/ChromaListe/posts/2017-05-30-noeunoeuf.html"},"Tylton":{"title":"Tylton","url":"/ChromaListe/posts/2017-05-22-tylton.html"},"Nénupiot":{"title":"Nénupiot","url":"/ChromaListe/posts/2017-05-21-nenupiot.html"},"Minidraco":{"title":"Minidraco","url":"/ChromaListe/posts/2017-05-21-minidraco.html"},"Tiboudet":{"title":"Tiboudet","url":"/ChromaListe/posts/2017-05-07-tiboudet.html"},"Kaiminus":{"title":"Kaiminus","url":"/ChromaListe/posts/2017-04-28-kaiminus.html"},"Tarenbulle":{"title":"Tarenbulle","url":"/ChromaListe/posts/2017-04-16-tarenbulle.html"},"Araqua":{"title":"Araqua","url":"/ChromaListe/posts/2017-04-01-araqua.html"},"Sabelette (Alola)":{"title":"Sabelette (Alola)","url":"/ChromaListe/posts/2017-03-26-sabelette-alola.html"},"Feuforêve":{"title":"Feuforêve","url":"/ChromaListe/posts/2017-03-14-feuforeve.html"},"Tadmorv (Alola)":{"title":"Tadmorv (Alola)","url":"/ChromaListe/posts/2017-03-11-tadmorv-alola.html"},"Rattata (Alola)":{"title":"Rattata (Alola)","url":"/ChromaListe/posts/2017-03-08-rattata-alola.html"},"Rocabot":{"title":"Rocabot","url":"/ChromaListe/posts/2017-03-04-rocabot.html"},"Nidoran♂":{"title":"Nidoran♂","url":"/ChromaListe/posts/2017-02-23-nidoran.html"},"Terhal":{"title":"Terhal","url":"/ChromaListe/posts/2017-02-19-terhal.html"},"Ectoplasma":{"title":"Ectoplasma","url":"/ChromaListe/posts/2017-02-17-ectoplasma.html"},"Spectrum":{"title":"Spectrum","url":"/ChromaListe/posts/2017-02-15-spectrum.html"},"Passerouge":{"title":"Passerouge","url":"/ChromaListe/posts/2017-02-11-passerouge.html"},"Reshiram":{"title":"Reshiram","url":"/ChromaListe/posts/2017-02-05-reshiram.html"},"Métamorph":{"title":"Métamorph","url":"/ChromaListe/posts/2017-02-04-metamorph.html"},"Pikachu":{"title":"Pikachu","url":"/ChromaListe/posts/2017-02-03-pikachu.html"},"Pichu":{"title":"Pichu","url":"/ChromaListe/posts/2017-02-03-pichu.html"},"Manglouton":{"title":"Manglouton","url":"/ChromaListe/posts/2017-01-31-manglouton.html"},"Nosferapti":{"title":"Nosferapti","url":"/ChromaListe/posts/2017-01-26-nosferapti.html"},"Caninos":{"title":"Caninos","url":"/ChromaListe/posts/2017-01-21-caninos.html"},"Nymphali":{"title":"Nymphali","url":"/ChromaListe/posts/2017-01-11-nymphali.html"},"Picassaut":{"title":"Picassaut","url":"/ChromaListe/posts/2016-12-22-picassaut.html"},"Vorastérie":{"title":"Vorastérie","url":"/ChromaListe/posts/2016-12-19-vorasterie.html"},"Plumeline":{"title":"Plumeline","url":"/ChromaListe/posts/2016-12-17-plumeline.html"},"Brindibou":{"title":"Brindibou","url":"/ChromaListe/posts/2016-12-16-brindibou.html"},"Bacabouh":{"title":"Bacabouh","url":"/ChromaListe/posts/2016-12-11-bacabouh.html"},"Rapasdepic":{"title":"Rapasdepic","url":"/ChromaListe/posts/2016-12-07-rapasdepic.html"},"Géolithe":{"title":"Géolithe","url":"/ChromaListe/posts/2016-11-22-geolithe.html"},"Entei":{"title":"Entei","url":"/ChromaListe/posts/2016-10-08-entei.html"},"Lokhlass":{"title":"Lokhlass","url":"/ChromaListe/posts/2016-08-26-lokhlass.html"},"Muplodocus":{"title":"Muplodocus","url":"/ChromaListe/posts/2016-08-20-muplodocus.html"},"Sonistrelle":{"title":"Sonistrelle","url":"/ChromaListe/posts/2016-08-14-sonistrelle.html"},"Colimucus":{"title":"Colimucus","url":"/ChromaListe/posts/2016-08-14-colimucus.html"},"Joliflor":{"title":"Joliflor","url":"/ChromaListe/posts/2016-07-18-joliflor.html"},"Rafflesia":{"title":"Rafflesia","url":"/ChromaListe/posts/2016-06-06-rafflesia.html"},"Regigigas":{"title":"Regigigas","url":"/ChromaListe/posts/2016-04-21-regigigas.html"},"Gamblast":{"title":"Gamblast","url":"/ChromaListe/posts/2016-04-19-gamblast.html"},"Flingouste":{"title":"Flingouste","url":"/ChromaListe/posts/2016-04-14-flingouste.html"},"Frison":{"title":"Frison","url":"/ChromaListe/posts/2016-04-07-frison.html"},"Électrode":{"title":"Électrode","url":"/ChromaListe/posts/2016-03-27-electrode.html"},"Voltorbe":{"title":"Voltorbe","url":"/ChromaListe/posts/2016-03-26-voltorbe.html"},"Hypocéan":{"title":"Hypocéan","url":"/ChromaListe/posts/2016-03-23-hypocean.html"},"Registeel":{"title":"Registeel","url":"/ChromaListe/posts/2016-03-21-registeel.html"},"Zigzaton":{"title":"Zigzaton","url":"/ChromaListe/posts/2016-03-13-zigzaton.html"},"Queulorior":{"title":"Queulorior","url":"/ChromaListe/posts/2016-03-12-queulorior.html"},"Mesmérella":{"title":"Mesmérella","url":"/ChromaListe/posts/2016-03-11-mesmerella.html"},"Scrutella":{"title":"Scrutella","url":"/ChromaListe/posts/2016-03-11-scrutella.html"},"Regice":{"title":"Regice","url":"/ChromaListe/posts/2016-03-08-regice.html"},"Hypotrempe":{"title":"Hypotrempe","url":"/ChromaListe/posts/2016-02-26-hypotrempe.html"},"Kranidos":{"title":"Kranidos","url":"/ChromaListe/posts/2016-02-20-kranidos.html"},"Ortide":{"title":"Ortide","url":"/ChromaListe/posts/2015-10-16-ortide.html"},"Tarinor":{"title":"Tarinor","url":"/ChromaListe/posts/2015-10-14-tarinor.html"},"Stari":{"title":"Stari","url":"/ChromaListe/posts/2015-10-14-stari.html"},"Grelaçon":{"title":"Grelaçon","url":"/ChromaListe/posts/2015-10-11-grelacon.html"},"Mammochon":{"title":"Mammochon","url":"/ChromaListe/posts/2015-10-07-mammochon.html"},"Stalgamin":{"title":"Stalgamin","url":"/ChromaListe/posts/2015-10-06-stalgamin.html"},"Zekrom":{"title":"Zekrom","url":"/ChromaListe/posts/2015-09-30-zekrom.html"},"Doduo":{"title":"Doduo","url":"/ChromaListe/posts/2015-08-21-doduo.html"},"Mystherbe":{"title":"Mystherbe","url":"/ChromaListe/posts/2015-08-10-mystherbe.html"},"Tarpaud":{"title":"Tarpaud","url":"/ChromaListe/posts/2015-07-10-tarpaud.html"},"Tartard":{"title":"Tartard","url":"/ChromaListe/posts/2015-07-08-tartard.html"},"Têtarte":{"title":"Têtarte","url":"/ChromaListe/posts/2015-07-07-tetarte.html"},"Zarbi":{"title":"Zarbi","url":"/ChromaListe/posts/2015-07-02-zarbi.html"},"Galegon":{"title":"Galegon","url":"/ChromaListe/posts/2015-06-21-galegon.html"},"Mysdibule":{"title":"Mysdibule","url":"/ChromaListe/posts/2015-06-20-mysdibule.html"},"Nostenfer":{"title":"Nostenfer","url":"/ChromaListe/posts/2015-06-20-nostenfer.html"},"Nosferalto":{"title":"Nosferalto","url":"/ChromaListe/posts/2015-06-18-nosferalto.html"},"Galekid":{"title":"Galekid","url":"/ChromaListe/posts/2015-06-18-galekid.html"},"Linéon":{"title":"Linéon","url":"/ChromaListe/posts/2015-06-17-lineon.html"},"Zigzaton":{"title":"Zigzaton","url":"/ChromaListe/posts/2015-06-15-zigzaton.html"},"Grainipiot":{"title":"Grainipiot","url":"/ChromaListe/posts/2015-06-12-grainipiot.html"},"Méditikka":{"title":"Méditikka","url":"/ChromaListe/posts/2015-05-23-meditikka.html"},"Goupix":{"title":"Goupix","url":"/ChromaListe/posts/2015-05-20-goupix.html"},"Cochignon":{"title":"Cochignon","url":"/ChromaListe/posts/2015-05-17-cochignon.html"},"Kaimorse":{"title":"Kaimorse","url":"/ChromaListe/posts/2015-05-01-kaimorse.html"},"Rosélia":{"title":"Rosélia","url":"/ChromaListe/posts/2015-04-24-roselia.html"},"Raikou":{"title":"Raikou","url":"/ChromaListe/posts/2015-04-18-raikou.html"},"Sorbébé":{"title":"Sorbébé","url":"/ChromaListe/posts/2015-04-04-sorbebe.html"},"Sharpedo":{"title":"Sharpedo","url":"/ChromaListe/posts/2015-04-03-sharpedo.html"},"Léviator":{"title":"Léviator","url":"/ChromaListe/posts/2015-04-02-leviator.html"},"Poissoroy":{"title":"Poissoroy","url":"/ChromaListe/posts/2015-04-01-poissoroy.html"},"Poissirène":{"title":"Poissirène","url":"/ChromaListe/posts/2015-04-01-poissirene.html"},"Wailmer":{"title":"Wailmer","url":"/ChromaListe/posts/2015-03-30-wailmer.html"},"Phogleur":{"title":"Phogleur","url":"/ChromaListe/posts/2015-03-27-phogleur.html"},"Nosferapti":{"title":"Nosferapti","url":"/ChromaListe/posts/2015-03-24-nosferapti.html"},"Cresselia":{"title":"Cresselia","url":"/ChromaListe/posts/2015-03-22-cresselia.html"},"Obalie":{"title":"Obalie","url":"/ChromaListe/posts/2015-03-22-obalie.html"},"Milobellus":{"title":"Milobellus","url":"/ChromaListe/posts/2015-02-24-milobellus.html"},"Barpau":{"title":"Barpau","url":"/ChromaListe/posts/2015-02-20-barpau.html"},"Séviper":{"title":"Séviper","url":"/ChromaListe/posts/2015-02-09-seviper.html"},"Latias":{"title":"Latias","url":"/ChromaListe/posts/2015-01-28-latias.html"},"Miamiasme":{"title":"Miamiasme","url":"/ChromaListe/posts/2015-01-20-miamiasme.html"},"Kyurem":{"title":"Kyurem","url":"/ChromaListe/posts/2015-01-19-kyurem.html"},"Regirock":{"title":"Regirock","url":"/ChromaListe/posts/2014-12-30-regirock.html"},"Mangriff":{"title":"Mangriff","url":"/ChromaListe/posts/2014-12-28-mangriff.html"},"Écrapince":{"title":"Écrapince","url":"/ChromaListe/posts/2014-12-16-ecrapince.html"},"Chuchmur":{"title":"Chuchmur","url":"/ChromaListe/posts/2014-10-23-chuchmur.html"},"Wattouat":{"title":"Wattouat","url":"/ChromaListe/posts/2014-10-18-wattouat.html"},"Camérupt":{"title":"Camérupt","url":"/ChromaListe/posts/2014-09-15-camerupt.html"},"Limonde":{"title":"Limonde","url":"/ChromaListe/posts/2014-09-07-limonde.html"},"Pachirisu":{"title":"Pachirisu","url":"/ChromaListe/posts/2014-09-07-pachirisu.html"},"Luxio":{"title":"Luxio","url":"/ChromaListe/posts/2014-09-06-luxio.html"},"Farfaduvet":{"title":"Farfaduvet","url":"/ChromaListe/posts/2014-08-29-farfaduvet.html"},"Doudouvet":{"title":"Doudouvet","url":"/ChromaListe/posts/2014-08-17-doudouvet.html"},"Métang":{"title":"Métang","url":"/ChromaListe/posts/2014-08-12-metang.html"},"Goélise":{"title":"Goélise","url":"/ChromaListe/posts/2014-08-12-goelise.html"},"Nodulithe":{"title":"Nodulithe","url":"/ChromaListe/posts/2014-08-06-nodulithe.html"},"Mime Jr.":{"title":"Mime Jr.","url":"/ChromaListe/posts/2014-08-05-mime-jr.html"},"M. Mime (Galar)":{"title":"M. Mime (Galar)","url":"/ChromaListe/posts/2014-08-05-m-mime-galar.html"},"Rémoraid":{"title":"Rémoraid","url":"/ChromaListe/posts/2014-08-03-remoraid.html"},"Loupio":{"title":"Loupio","url":"/ChromaListe/posts/2014-08-03-loupio.html"},"Mamanbo":{"title":"Mamanbo","url":"/ChromaListe/posts/2014-08-02-mamanbo.html"},"Ptitard":{"title":"Ptitard","url":"/ChromaListe/posts/2014-07-26-ptitard.html"},"Évoli":{"title":"Évoli","url":"/ChromaListe/posts/2014-07-03-evoli.html"},"Banshitrouye":{"title":"Banshitrouye","url":"/ChromaListe/posts/2014-05-07-banshitrouye.html"},"Pitrouille":{"title":"Pitrouille","url":"/ChromaListe/posts/2014-04-21-pitrouille.html"},"Scorvol":{"title":"Scorvol","url":"/ChromaListe/posts/2014-04-19-scorvol.html"},"Scorplane":{"title":"Scorplane","url":"/ChromaListe/posts/2014-03-22-scorplane.html"},"Exagide":{"title":"Exagide","url":"/ChromaListe/posts/2014-03-07-exagide.html"},"Lumivole":{"title":"Lumivole","url":"/ChromaListe/posts/2014-03-02-lumivole.html"},"Magicarpe":{"title":"Magicarpe","url":"/ChromaListe/posts/2014-02-21-magicarpe.html"},"M. Mime":{"title":"M. Mime","url":"/ChromaListe/posts/2014-02-09-m-mime.html"},"Insolourdo":{"title":"Insolourdo","url":"/ChromaListe/posts/2014-02-07-insolourdo.html"},"Relicanth":{"title":"Relicanth","url":"/ChromaListe/posts/2013-10-27-relicanth.html"},"Séracrawl":{"title":"Séracrawl","url":"/ChromaListe/posts/2013-10-13-seracrawl.html"}};$("#searchInput").keyup(function(){updateSearchResults();});$("#searchInput").change(function(){updateSearchResults();});randomizePost();});