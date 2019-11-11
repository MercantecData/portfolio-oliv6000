// function erstater string-void-int osv, den kan retunere alting eller ingenting

function buttonClicked(t)
{
    var SetGetDate = document.getElementById('demo');
    SetGetDate.innerHTML = new Date().getHours() + ":" + new Date().getMinutes();
    var TimeToWait = 500;
    setTimeout(function(){
    buttonClicked();
    }, TimeToWait);
    
}