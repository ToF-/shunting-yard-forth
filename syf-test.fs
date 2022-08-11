require ffl/tst.fs
\ see http://irdvo.nl/FFL/

require syf.fs

\ how to run this :
\ gforth syf-test.fs

page

t{ ." a dummy test" cr
  ." shows that we have a test harness" cr
  2 2 +   4 ?s
}t

bye

