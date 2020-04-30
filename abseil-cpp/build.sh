set -e
base_dir=$(cd "$(dirname "$0")";pwd)
cd $base_dir/lts_2020_02_25

rm build -rf
mkdir build
pushd build

cmake -DBUILD_SHARED_LIBS=ON -DABSL_RUN_TESTS=OFF -DCMAKE_INSTALL_PREFIX=/usr/local/ ..
make -j4
make install

popd
rm build -rf

