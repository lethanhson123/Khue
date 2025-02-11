// Morris Area Chart
Morris.Area({
	element: "areaChart",
	data: [
		{ y: "2014", a: 10, b: 5, c: 2 },
		{ y: "2015", a: 40, b: 15, c: 8 },
		{ y: "2016", a: 15, b: 50, c: 25 },
		{ y: "2017", a: 40, b: 15, c: 7 },
		{ y: "2018", a: 20, b: 30, c: 20 },
		{ y: "2019", a: 35, b: 15, c: 20 },
		{ y: "2020", a: 20, b: 15, c: 51 },
	],
	xkey: "y",
	ykeys: ["a", "b", "c"],
	behaveLikeLine: !0,
	pointSize: 0,
	labels: ["Sales", "Expenses", "Projects"],
	pointStrokeColors: [
		"#501a92", "#7348a8", "#9676be", "#b9a3d3","#dcd1e9", "#eee8f4"
	],
	gridLineColor: "#dfd6ff",
	lineColors: [
		"#501a92", "#7348a8", "#9676be", "#b9a3d3","#dcd1e9", "#eee8f4"
	],
	gridtextSize: 10,
	fillOpacity: 0.4,
	lineWidth: 0,
	hideHover: "auto",
	resize: true,
	redraw: true,
});
