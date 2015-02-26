/*
Starting off with getting 1, then using basic operators 
to get the character codes for the characters in Hello, World! 
and printing them out.
*/
n = -~[], 			// 1
t = n+n, 			// 2
i = t << t, 		// 8
_ = i << t, 		// 32 (space)
d = _ - i + n<<t, 	// 100 (d)
l = d + i, 			// 108 (l)
o = l + t + n; 		// 111 (o)
alert(String.fromCharCode(
		i * i + i,	// 72 (H)
		-~d,		// 101 (e)
		l,
		l,
		o,
		l - _ * t,	// 44 (,)
		_,
		d - d / i,	// 87.5 truncates to 87 (W)
		o,
		o + o % l,	// 114 (r)
		l,
		d,
		-~_ 		// 33 (!)
		))