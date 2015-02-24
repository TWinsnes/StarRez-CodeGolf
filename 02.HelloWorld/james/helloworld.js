// this ones quite straight forward and simple. start with the number 1
// and work on from there until we have obtained all the ascii codes for
// all the characters needed. I've tried to make the arithmetic as small
// as possible but there is most probably a well and truly shorter way
// to do this. Yep

var n = true + false, 			// 1
	t = n << n, 				// 2
	i = t << t, 				// 8
	d = i * (n + t) + n << t, 	// 100 (d)
	e = d + n, 					// 101 (e)
	l = d + i, 					// 108 (l)
	_ = i << t, 				// 32 (space)
	c = l - _ * t,				// 44 (,)
	x = _ + n,					// 33 (!)
	H = _ + _ + i,				// 72 (H)
	W = c + c - n,				// 87 (W)
	o = W + _ - i,				// 111 (o)
	r = o + n + t;				// 114 (r)

alert(String.fromCharCode(H,e,l,l,o,c,_,W,o,r,l,d,x));