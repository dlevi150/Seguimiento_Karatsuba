Teoria de Algoritmos I, TP 1
Estudiante: Dolores Levi
Padron: 105993
Fecha de Entrega:

105993
X = 33594113
Y = 29985355

KARATSUBA

33594113 * 29985355, n = 8
X = 33594113
Y = 29985355
x1 = 3359 , x0 = 4113 , y1 = 2998 , y0 = 5355
x1 + x0 = 7472, y1 + y0 = 8353
P = Karatsuba(7472,8353)
	7472 * 8353, n = 4
	X = 7472
	Y = 8353
	x1 = 74, x0 = 72, y1 = 83, y0 = 53
	x1 + x0 = 146,  y1 + y0 = 136
	P = Karatsuba(146,136)
		0146 * 0136, n = 4
		X = 0146
		Y = 0136
		x1 = 01, x0 = 46, y1 = 01, y0 = 36
		x1 + x0 = 47, y1 + y0 = 37
		P = Karatsuba(47, 37)
			47 * 37, n = 2
			X = 47
			Y = 37
			x1 = 4, x0 = 7, y1 = 3, y0 = 7
			x1 + x0 = 11, y1 + y0 = 10
			P = Karatsuba(11,10)
				11 * 10, n =2
				X = 11
				Y = 10
				x1 = 1, x0 = 1, y1 = 1, y0 = 0
				x1 + x0 = 2, y1 + y0 = 1
				P = Karatsuba (2, 1)
					2 * 1 , n = 1
					CASO BASE devuelve 2*1 = 2
				P = 2
				x1y1 = Karatsuba(1,1)
					1*1 , n = 1
					CASO BASE devuelve 1*1 = 1
				x1y1 = 1
				x0y0 = Karatsuba(1,0)
                    1 * 0 , n = 1
					CASO BASE devuelve 1*0 = 0
                x0y0 = 0
                devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
                devuelve 1 * 10^2 + (2 - 1 - 0) * 10^1 + 0
                devuelve 110
            P = 110
            x1y1 = Karatsuba(4,3)
                4 * 3 , n = 1
                CASO BASE devuelve 4*3 = 12
            x1y1 = 12
            x0y0 = Karatsuba(7,7)
                7 * 7, n = 1
                CASO BASE devuelve 7*7 = 49
            x0y0 = 49
            devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
            devuelve 12 * 10^2 + (110 - 12 - 49) * 10^1 + 49
            devuelve 1739
        P = 1739
        x1y1 = Karatsuba(01,01)
           01 * 01 == 1 * 1, n = 1
           CASO BASE devuelve 1*1 = 1
        x1y1 = 1
        x0y0 = Karatsuba(46,36)
            46 * 36, n = 2
            X = 46
            Y = 36
            x1 = 4, x0 = 6, y1 = 3, y0 = 6
            x1 + x0 = 10, y1 + y0 = 9
            P = Karatsuba(10, 09) 
                10 * 09 , n = 2
                X = 10
                Y = 09
                x1 = 1, x0 = 0, y1 = 0, y0 = 9
                x1 + x0 = 1, y1 + y0 = 9
                P = Karatsuba(1,9)
                    1 * 9, n = 1
                    CASO BASE devuelve 1*9 = 9
                P = 9
                x1y1 = Karatsuba(1,0)
                    1 * 0, n = 1
                    CASO BASE devuelve 1*0 = 9
                x1y1 = 0
                x0y0 = Karatsuba(0,9)
                    0 * 9, n = 1
                    CASO BASE devuelve 0*9 = 0
                x0y0 = 0
                devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
                devuelve 0 * 10^2 + (9 - 0 - 0) * 10^1 + 0
                devuelve 90
            P = 90
            x1y1 = Karatsuba(4,3)
                4 * 3, n = 1
                CASO BASE devuelve 4*3 = 12
            x1y1 = 12
            x0y0 = Karatsuba(6,6)
                6 * 6 , n = 1
                CASO BASE devuelve 6*6 = 36
            x0y0 = 36
            devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
            devuelve 12 * 10^2 + (90 - 12 - 36) * 10^1 + 36
            devuelve 1656
        x0y0 = 1656
        devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
        devuelve 1 * 10^4 + (1739 - 1 - 1656) * 10^2 + 1656
        devuelve 19856
    P = 19856
    x1y1 = Karatsuba(74,83)
        74 * 83 , n = 2
        X = 74
        Y = 83
        x1 = 7, x0 = 4, y1 = 8, y0 = 3
        x1 + x0 = 11, y1 + y0 = 11
        P = Karatsuba(11,11)
            11 * 11, n = 2
            X = 11
            Y = 11
            x1 = 1, x0 = 1, y1 = 1, y0 = 1
            x1 + x0 = 2, y1 + y0 = 2
            P = Karatsuba(2,2)
                2 * 2, n = 1
                CASO BASE devuelve 2*2 = 4
            P = 4
            x1y1 = Karatsuba(1,1)
                1 * 1, n = 1
                CASO BASE devuelve 1*1 = 1
            x1y1 = 1
            x0y0 = Karatsuba(1,1)
                1 * 1, n = 1
                CASO BASE devuelve 1*1 = 1
            x0y0 = 1
            devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
            devuelve 1 * 10^2 + (4 - 1 - 1) * 10^1 + 1
            devuelve 121
        P = 121
        x1y1 = Karatsuba(7,8)
            7 * 8 , n = 1
            CASO BASE devuelve 7*8 = 56
        x1y1 = 56
        x0y0 = Karatsuba(4,3)
            4 * 3, n = 1
            CASO BASE devuelve 4*3 = 12
        x0y0 = 12
        devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
        devuelve 56 * 10^2 + (121 - 56 - 12) * 10^1 + 12
        devuelve 6142
    x1y1 = 6142
    x0y0 = Karatsuba(72,53)
        72 * 53, n = 2
        X = 72
        Y = 53
        x1 = 7, x0 = 2, y1 = 5, y0 = 3
        x1 + x0 = 9,  y1 + y0 = 8
        P = Karatsuba(9,8)
            9 * 8, n = 1
            CASO BASE devuelve 9*8 = 72
        P = 72
        x1y1 = Karatsuba(7,5)
            7 * 5 , n = 1
            CASO BASE devuelve 7*5 = 35
        x1y1 = 30
        x0y0 = Karatsuba(2,3)
            2 * 3, n = 1
            CASO BASE devuelve 2*3 = 6
        x0y0 = 6
        devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
        devuelve 35 * 10^2 + (72 - 35 - 6) * 10^1 + 6
        devuelve 3816
    x0y0 = 3816
    devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
    devuelve 6142 * 10^4 + (19856 - 6142 - 3816) * 10^2 + 3816
    devuelve 62413616
P = 62413616
x1y1 = Karatsuba(3359,2998)
    3359 * 2998, n = 4
    x1 = 33, x0 = 59, y1 = 29, y0 = 98
    P = Karatsuba(0092,0127)
        0092 * 0127, n = 4
        x1 = 00, x0 = 92, y1 = 01, y0 = 27
        P = Karatsuba(92, 28)
            92 * 28, n = 2
            x1 = 9, x0 = 2, y1 = 2, y0 = 8
            P = Karatsuba(11,10)
                11 * 10, n = 2
				X = 11
				Y = 10
				x1 = 1, x0 = 1, y1 = 1, y0 = 0
				x1 + x0 = 2, y1 + y0 = 1
				P = Karatsuba (2, 1)
					2 * 1 , n = 1
					CASO BASE devuelve 2*1 = 2
				P = 2
				x1y1 = Karatsuba(1,1)
					1*1 , n = 1
					CASO BASE devuelve 1*1 = 1
				x1y1 = 1
				x0y0 = Karatsuba(1,0)
                    1 * 0 , n = 1
					CASO BASE devuelve 1*0 = 0
                x0y0 = 0
                devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
                devuelve 1 * 10^2 + (2 - 1 - 0) * 10^1 + 0
                devuelve 110
            P = 110
            x1y1 = Karatsuba(9,2)
                9 * 2, n = 2
                CASO BASE devuelve 9*2 = 18
            x1y1 = 18
            x0y0 = Karatsuba(2,8)
                2 * 8, n = 2
                CASO BASE devuelve 2*8 = 16
            x0y0 = 16
            devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
            devuelve 18 * 10^2 + (110 - 18 - 16) * 10^1 + 16
            devuelve 2576
        P = 2576
        x1y1 = Karatsuba(00,01)
            00 * 01, n = 2
            x1 = 0, x0 = 0, y1 = 0, y0 = 1
            P = Karatsuba(0,1) CASO BASE
            P = 0
            x1y1 = Karatsuba(0,0) CASO BASE
            x1y1 = 0
            x0y0 = Karatsuba(0,1) CASO BASE
            x0y0 = 0
            devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
            devuelve 0 * 10^2 + (0 - 0 - 0) * 10^1 + 0
            devuelve 0
        x1y1 = 0
        x0y0 = Karatsuba(92, 27)
            92 * 27, n = 2
            x1 = 9, x0 = 2, y1 = 2, y0 = 7
            P = Karatsuba(11,09)
                11 * 09 , n = 2
                x1 = 1, x0 = 1, y1 = 0, y0 = 9
                P = Karatsuba(2,9) CASO BASE
                P = 18
                x1y1 = Karatsuba(1,0) CASO BASE
                x1y1 = 0
                x0y0 = Karatsuba(1,9) CASO BASE
                x0y0 = 9
                devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
                devuelve 0 * 10^2 + (18 - 0 - 9) * 10^1 + 9
                devuelve 99
            P = 99
            x1y1 = Karatsuba(9,2) CASO BASE
            x1y1 = 18
            x0y0 = Karatsuba(2,7) CASO BASE
            x0y0 = 14
            devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
            devuelve 18 * 10^2 + (99 - 18 - 14) * 10^1 + 14
            devuelve 2484
        x0y0 = 2484
        devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
        devuelve 0 * 10^4 + (2576 - 0 - 2484) * 10^2 + 2484
        devuelve 11684
    P = 11684
    x1y1 = Karatsuba(33,29)
        33 * 29, n = 2
        x1 = 3, x0 = 3, y1 = 2, y0 = 9
        x1 + x0 = 6, y1 + y0 = 11
        P = Karatsuba(06,11)
            06 * 11 , n = 2
            x1 = 0, x0 = 6, y1 = 1, y0 = 1
            x1 + x0 = 6, y1 + y0 = 2
            P = Karatsuba(6,2) CASO BASE
            P = 12
            x1y1 = Karatsuba(0,1) CASO BASE
            x1y1 = 0
            x0y0 = Karatsuba(6,1) CASO BASE
            x0y0 = 6
            devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
            devuelve 0 * 10^2 + (12 - 0 - 6) * 10^1 + 6
            devuelve 66
        P = 66
        x1y1 = Karatsuba(3,2) CASO BASE
        x1y1 = 6
        x0y0 = Karatsuba(3,9) CASO BASE
        x0y0 = 27
        devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
        devuelve 6 * 10^2 + (66 - 6 - 27) * 10^1 + 27
        devuelve 957
    x1y1 = 957
    x0y0 = Karatsuba(59,98)
        59 * 98, n = 2
        x1 = 5, x0 = 9, y1 = 9, y0 = 8
        x1 + x0 = 14, y1 + y0 = 17
        P = Karatsuba(14,17)
            14 * 17, n = 2
            x1 = 1, x0 = 4, y1 = 1, y0 = 7
            x1 + x0 = 5, y1 + y0 = 8
            P = Karatsuba(5,8) CASO BASE
            P = 40
            x1y1 = Karatsuba(1,1) CASO BASE
            x1y1 = 1
            x0y0 = Karatsuba(4,7) CASO BASE
            x0y0 = 28
            devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
            devuelve 1 * 10^2 + (40 - 1 - 28) * 10^1 + 28
            devuelve 238
        P = 238
        x1y1 = Karatsuba(5,9) CASO BASE
        x1y1 = 45
        x0y0 = Karatsuba(9,8) CASO BASE
        x0y0 = 72
        devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
        devuelve 45 * 10^2 + (238 - 45 - 72) * 10^1 + 72
        devuelve 5782
    x0y0 = 5782
    devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
    devuelve 957 * 10^4 + (11684 - 957 - 5782) * 10^2 + 5782
    devuelve 10070282
x1y1 = 10070282
x0y0 = Karatsuba(4113,5355)
    4113 * 5355, n = 4
    x1 = 41, x0 = 13, y1 = 53, y0 = 55
    x1 + x0 = 54, y1 + y0 = 108
    P = Karatsuba(0054,0108)
        0054 * 0108, n = 4
        x1 = 00, x0 = 54, y1 = 01, y0 = 08
        P = Karatsuba(54,09)
            54 * 09 , n = 2
            x1 = 5, x0 = 4, y1 = 0, y0 = 9
            P = Karatsuba(9,9) CASO BASE
            P = 81
            x1y1 = (5,0)
            x1y1 = 0
            x0y0 = Karatsuba(4,9) CASO BASE
            x0y0 = 36
            devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
            devuelve 0 * 10^2 + (81 - 0 - 36) * 10^1 + 36
            devuelve 486
        P = 486
        x1y1 = Karatsuba(00,01)
            00 * 01 , n = 2
            P = Karatsuba(0,1) CASO BASE
            P = 0
            x1y1 = Karatsuba(0,0) CASO BASE
            x1y1 = 0
            x0y0 = Karatsuba(0,1) CASO BASE
            x0y0 = 0
            devuelve 0
        x1y1 = 0
        x0y0 = Karatsuba(54,08)
            54 * 08 , n = 2
            x1 = 5, x0 = 4, y1 = 0, y0 = 8
            P = Karatsuba(9,8) CASO BASE
            P = 72
            x1y1 = Karatsuba(5,0) CASO BASE
            x1y1 = 0
            x0y0 = Karatsuba(4,8) CASO BASE
            x0y0 = 32
            devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
            devuelve 0 * 10^2 + (72 - 0 - 32) * 10^1 + 32
            devuelve 432
        x0y0 = 432
        devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
        devuelve 0 * 10^4 + (486 - 0 - 432) * 10^2 + 432
        devuelve 5832
    P = 5832
    x1y1 = Karatsuba(41,53)
        41 * 53, n = 2
        P = Karatsuba(5,8) CASO BASE
        P = 40
        x1y1 = Karatsuba(4,5) CASO BASE
        x1y1 = 20
        x0y0 = Karatsuba(1,3) CASO BASE
        x0y0 = 3
        devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
        devuelve 20 * 10^2 + (40 - 20 - 3) * 10^1 + 3
        devuelve 2173
    x1y1 = 2173
    x0y0 = Karatsuba(13,55)
        13 * 55, n = 2
        P = Karatsuba(04,10)
            04 * 10, n = 2
            P = Karatsuba(4,1) CASO BASE
            P = 4
            x1y1 = Karatsuba(0,1) CASO BASE
            x1y1 = 0
            x0y0 = Karatsuba(4,0) CASO BASE
            x0y0 = 0
            devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
            devuelve 0 * 10^2 + (4 - 0 - 0) * 10^1 + 0
            devuelve 40
        P = 40
        x1y1 = Karatsuba(1,5) CASO BASE
        x1y1 = 5
        x0y0 = Karatsuba(3,5) CASO BASE
        x0y0 = 15
        devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
        devuelve 5 * 10^2 + (40 - 5 - 15) * 10^1 + 15
        devuelve 715
    x0y0 = 715
    devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
    devuelve 2173 * 10^4 + (5832 - 2173 - 715) * 10^2 + 715
    devuelve 22025115
x0y0 = 22025115
devuelve x1y1 * 10^n + (P - x1y1 - x0y0) * 10^(n/2) + x0y0
devuelve 10070282 * 10^8 + (62413616 - 10070282 - 22025115) * 10^4 + 22025115
devuelve 1007331404215115







 
