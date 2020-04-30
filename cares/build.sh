set -e
base_dir=$(cd "$(dirname "$0")";pwd)
rm -fr $base_dir/1.16.0/build/
mkdir $base_dir/1.16.0/build/
cd $base_dir/1.16.0/build/

cmake -DCMAKE_BUILD_TYPE=Release -DCMAKE_INSTALL_PREFIX=/usr/local/ $base_dir/1.16.0/
make -j4
make install

rm -fr $base_dir/1.16.0/build/
