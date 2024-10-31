(function () {

    var link = document.querySelector("link[rel*='icon']") || document.createElement('link');
    document.head.removeChild(link);
    link = document.querySelector("link[rel*='icon']") || document.createElement('link');
    document.head.removeChild(link);

    link = document.createElement('link');
    link.type = 'image/png';
    link.rel = 'icon';
    link.href = 'kaf_logo.png';
    document.getElementsByTagName('head')[0].appendChild(link);

    //var link = document.querySelector("link[rel*='icon']") || document.createElement('link');
    //document.head.removeChild(link);
    //link = document.querySelector("link[rel*='icon']") || document.createElement('link');
    //document.head.removeChild(link);
    //link = document.createElement('link');
    //link.type = 'image/x-icon';
    //link.rel = 'shortcut icon';
    //link.href = 'kaf_logo.png';
    //document.getElementsByTagName('head')[0].appendChild(link);
})();