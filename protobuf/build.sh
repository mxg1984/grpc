set -e
base_dir=$(cd "$(dirname "$0")";pwd)
cd $base_dir/3.10.0
bash autogen.sh
./configure --prefix=/usr/local/
make -j4
make install
ldconfig
cd $base_dir/3.10.0/python
python setup.py build
python setup.py install
