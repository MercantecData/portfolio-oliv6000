// function erstater string-void-int osv, den kan retunere alting eller ingenting

function AddLiveTime(t)
{
    var SetGetDate = document.getElementById('demo');
    SetGetDate.innerHTML = new Date().getHours() + ":" + new Date().getMinutes();
    var TimeToWait = 500;
    setTimeout(function(){
    AddLiveTime();
    }, TimeToWait);
}

function AddPicture()
{
    document.getElementById('OliverPicture').style.display = "block";
}

function RemovePicture()
{
    document.getElementById('OliverPicture').style.display = "none";
}



// Here i change the data within the button with the id "ChangeTekst"
function ChangeButtonTekst(t)
{
    document.getElementById('ChangeTekst').innerHTML = "hey there";
}


function AddArray()
{
    var MineSpil = ["GTA 5" ," CsGo", " ARK Survival evolved & and much more!"];

    document.getElementById('MyGames').innerText = MineSpil;
}

function AddComent()
{
    var usercomment = document.getElementById('UserCommentt').value;
    document.getElementById('UserCommentPlaceHold').innerText = usercomment;
}