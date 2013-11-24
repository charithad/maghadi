$(document).ready(function() {
			var pepe = $.fn.fullpage({
				/*slidesColor: ['#1bbc9b', '#4BBFC3', '#7BAABE', 'whitesmoke', '#ccddff'],*/
				anchors: ['firstPage', 'secondPage', '3rdPage', '4thpage', 'lastPage'],
				menu: '#menu'
			});
	$('.tableCell').css("padding-top")="0px";	
			
})

$('#my-carousel').carousel({
  
      interval: 5000,
      cycle: true
  
  });
  
  $('#my-news-carousel').carousel({
  
      interval: 7000,
      cycle: true
  
  });
  
  $("#BtnSub").click(function () {
  
      var t1 = $("#TextBox1").val();
      var t2 = $("#TextBox2").val();
      var t13 = $("#TextBox13").val();
      
      if (t1 == "") {
          alert("First Name Field Can Not be Empty");
          return false;
      }
  
      if (t2 == "") {
          alert("Last Name Field Can Not be Empty");
          return false;
      }
  
      if (t13 == "") {
          alert("E-Mail Field Can Not be Empty");
          return false;
      }
  
  });
	