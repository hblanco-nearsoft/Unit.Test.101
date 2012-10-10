(function ($) {
	'use strict';
	var slides = $('div.slides > div.slide'),
		current = 0,
		totalSlides = slides.length - 1,
		prevBtn,
		nextBtn;

	function next(e) {
		current = current === totalSlides ?
				  0 : (current += 1);
		$.scrollTo(slides[current], 800);
	}

	function prev(e) {
		current = current === 0 ?
				  totalSlides : (current -= 1);
		$.scrollTo(slides[current], 800);
	}

	function setHeight() {
		$('div.slide').css({'height': window.innerHeight});
	}

	function buildSlideIndex() {
		var headers = $('h1.project-name'),
			agenda	= $('ol.agenda');

		headers.each(function (idx, element) {
			var anchor = $('<a/>', { href: '#'}),
				li = $('<li/>');

			anchor.text(element.textContent);
			li.append(anchor);
			agenda.append(li);
		});
	}

	$(document).ready(function () {
		var $document = $(document);
		
		$document.jkey('left', prev);
		$document.jkey('k', prev);
		$document.jkey('h', prev);
		$document.jkey('right', next);
		$document.jkey('space', next);
		$document.jkey('enter', next);
		$document.jkey('j', next);
		$document.jkey('l', next);

		$('#prev').click(prev);	
		$('#next').click(next);

		setHeight();
		buildSlideIndex();
		$.scrollTo('0px', 800);
	});
}(jQuery));