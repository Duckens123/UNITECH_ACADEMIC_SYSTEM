let pg=document.querySelector('.page');
    let menu=document.querySelector('.menu')
    function showPage(page){
      document.querySelectorAll('.page').forEach(page=>{
        page.style.display='none';
      })
      
      document.querySelector(`#${page}`).style.display='block';
    }

    document.addEventListener('DOMContentLoaded', function(){
      document.querySelectorAll('.menu').forEach(menu => {
          menu.onclick = function(){
            showPage(this.dataset.page);
          }
      });

    });